using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HardwareRentalApp.Classes
{
    internal class NumberFormatter
    {
        private static readonly char[] englishDigits =
            { '0','1','2','3','4','5','6','7','8','9' };

        private static readonly char[] marathiDigits =
            { '०','१','२','३','४','५','६','७','८','९' };

        // 🔹 Format any value with optional numeric format
        public static string Format(object value, string format = null)
        {
            if (value == null)
                return "";

            string result;

            if (value is IFormattable formattable && format != null)
                result = formattable.ToString(format, CultureInfo.CurrentCulture);
            else
                result = value.ToString();

            return ConvertDigitsIfNeeded(result);
        }

        // 🔹 Convert digits only if Marathi culture is active
        private static string ConvertDigitsIfNeeded(string input)
        {
            if (CultureInfo.CurrentCulture.Name != "mr-IN")
                return input;

            for (int i = 0; i < englishDigits.Length; i++)
            {
                input = input.Replace(englishDigits[i], marathiDigits[i]);
            }

            return input;
        }

        // 🔹 Apply automatic Marathi formatting to a DataGridView
        public static void ApplyToDataGridView(DataGridView dgv)
        {
            dgv.CellFormatting += (s, e) =>
            {
                if (e.Value != null)
                {
                    e.Value = ConvertDigitsIfNeeded(e.Value.ToString());
                    e.FormattingApplied = true;
                }
            };
        }
    }
}
