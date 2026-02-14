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
        // ========================================
        // Digit Maps (Clear + Maintainable)
        // ========================================
        private static readonly char[] englishDigits =
            { '0','1','2','3','4','5','6','7','8','9' };

        private static readonly char[] marathiDigits =
            { '०','१','२','३','४','५','६','७','८','९' };

        // ========================================
        // Attach Formatter To DataGridView
        // ========================================
        public static void ApplyToDataGridView(DataGridView dgv)
        {
            dgv.CellFormatting -= Dgv_CellFormatting;
            dgv.CellFormatting += Dgv_CellFormatting;

            dgv.CellParsing -= Dgv_CellParsing;
            dgv.CellParsing += Dgv_CellParsing;
        }

        // ========================================
        // DISPLAY: English ➜ Marathi
        // ========================================
        private static void Dgv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value == null)
                return;

            // Only apply if current culture is Marathi
            if (System.Threading.Thread.CurrentThread.CurrentCulture.Name != "mr-IN")
                return;

            if (IsNumericType(e.Value))
            {
                string english = e.Value.ToString();
                e.Value = ConvertDigits(english, englishDigits, marathiDigits);
                e.FormattingApplied = true;
            }
        }

        // ========================================
        // PROCESSING: Marathi ➜ English
        // ========================================
        private static void Dgv_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            if (e.Value == null)
                return;

            if (System.Threading.Thread.CurrentThread.CurrentCulture.Name != "mr-IN")
                return;

            string input = e.Value.ToString();

            string english = ConvertDigits(input, marathiDigits, englishDigits);

            if (int.TryParse(english, out int intValue))
            {
                e.Value = intValue;
                e.ParsingApplied = true;
            }
            else if (decimal.TryParse(english, out decimal decimalValue))
            {
                e.Value = decimalValue;
                e.ParsingApplied = true;
            }
            else if (double.TryParse(english, out double doubleValue))
            {
                e.Value = doubleValue;
                e.ParsingApplied = true;
            }
        }

        public static string ConvertToEnglishDigits(string input)
        {
            return ConvertDigits(input, marathiDigits, englishDigits);
        }

        // ========================================
        // Generic Digit Converter
        // ========================================
        private static string ConvertDigits(string input, char[] source, char[] target)
        {
            char[] result = input.ToCharArray();

            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < source.Length; j++)
                {
                    if (result[i] == source[j])
                    {
                        result[i] = target[j];
                        break;
                    }
                }
            }

            return new string(result);
        }

        // ========================================
        // Numeric Type Checker
        // ========================================
        private static bool IsNumericType(object value)
        {
            return value is int ||
                   value is long ||
                   value is short ||
                   value is decimal ||
                   value is double ||
                   value is float;
        }
    }
}
