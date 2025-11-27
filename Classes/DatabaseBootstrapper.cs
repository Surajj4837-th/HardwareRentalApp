// DatabaseBootstrapper.cs
using System;
using System.Configuration;
using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Security.AccessControl;
using System.Security.Principal;

public static class DatabaseBootstrapper
{
    public static void EnsureDatabaseInAppData()
    {
        string appDataDir = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            ConfigurationManager.AppSettings["InstalledPath"]
        );

        if (!Directory.Exists(appDataDir))
            Directory.CreateDirectory(appDataDir);

        string targetMdf = Path.Combine(appDataDir, "HardwareRentalApp(Release).mdf");
        string targetLdf = Path.Combine(appDataDir, "HardwareRentalApp(Release)_log.ldf"); // standard log file naming

        string sourceMdf = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "HardwareRentalApp(Release).mdf");
        string sourceLdf = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data", "HardwareRentalApp(Release)_log.ldf");

        if (!File.Exists(targetMdf))
        {
            File.Copy(sourceMdf, targetMdf);

            // Remove Read-Only attribute if present
            FileAttributes attributes = File.GetAttributes(targetMdf);
            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                MakeFileFullyAccessible(targetMdf);
            }
        }

        // Copy LDF if it exists
        if (File.Exists(sourceLdf) && !File.Exists(targetLdf))
        {
            File.Copy(sourceLdf, targetLdf);

            // Remove Read-Only attribute if present
            FileAttributes attributes = File.GetAttributes(targetMdf);
            if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
            {
                MakeFileFullyAccessible(targetLdf);
            }
        }
    }

    public static bool IsDevelopmentMode()
    {
        return Debugger.IsAttached; // Or use a config flag
    }

    public static void MakeFileFullyAccessible(string filePath)
    {
        // Ensure the file exists
        if (!File.Exists(filePath))
            return;

        // Get the current user's identity
        string currentUser = WindowsIdentity.GetCurrent().Name;

        // Get the file's current ACL
        FileSecurity fileSecurity = new FileInfo(filePath).GetAccessControl();

        // Add full control access for the current user
        fileSecurity.AddAccessRule(new FileSystemAccessRule(
            currentUser,
            FileSystemRights.FullControl,
            AccessControlType.Allow));

        // Apply the updated access control to the file
        new FileInfo(filePath).SetAccessControl(fileSecurity);
    }
}
