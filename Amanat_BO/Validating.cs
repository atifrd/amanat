using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Amanat_BO
{
    public class Validating
    {
        static bool DistinationDateIsValid(DateTime FromDate, DateTime ToDate)
        {
            if (FromDate >= ToDate) return false;
            return true;
        }
        /// <summary> 

        /// Test for a regex expression match in the text box and 

        /// return the results - the example uses a regular 

        /// expression used to validate a phone number 

        /// </summary> 

        /// <returns>boolean</returns> 

        private bool txtRegExStringIsValid(string textToValidate)
        {

            Regex TheRegExpression;

            string TheTextToValidate;

            string TheRegExTest = @"[2-9]\d{2}-\d{3}-\d{4}";

            TheTextToValidate = textToValidate;

            TheRegExpression = new Regex(TheRegExTest);

            // test text with expression 

            if (TheRegExpression.IsMatch(TheTextToValidate))
            {

                return true;

            }

            else
            {

                return false;

            }
        }

        /// <summary> 

        /// Test for non-numeric values in the text box and 

        /// also make sure the textbox is not empty 

        /// </summary> 

        /// <returns>boolean</returns> 

        public static bool txtNumericStringIsValid(string txt)
        {

            if (txt == string.Empty)
            {

                return true;

            }

            char[] testArr = txt.ToCharArray();

            bool testBool = false;

            for (int i = 0; i < testArr.Length; i++)
            {

                if (!char.IsNumber(testArr[i]))
                {

                    testBool = true;

                }

            }

            return testBool;
        }

        /// <summary> 

        /// Test for non-alpha values in the text box and 

        /// also make sure that the textbox is not empty 

        /// </summary> 

        /// <returns>boolean</returns> 

        private bool txtAlphaStringIsValid(string txtAlphaString)
        {

            // first make sure the textbox contains something 

            if (txtAlphaString == string.Empty)
            {

                return true;

            }

            // test each character in the textbox 

            char[] testArr = txtAlphaString.ToCharArray();

            bool testBool = false;

            for (int i = 0; i < testArr.Length; i++)
            {

                if (!char.IsLetter(testArr[i]))
                {

                    testBool = true;

                }

            }

            return testBool;
        }

        /// <summary> 

        /// Test for numeric values between 50 and 100 in the text box and 

        /// return the results 

        /// </summary> 

        /// <returns>boolean</returns> 

        private bool txtRangeValidationIsValid(string txtRangeValidation)
        {

            int tmpVal = 0;


            try
            {

                tmpVal = Convert.ToInt32(txtRangeValidation);

            }

            catch { }



            bool testBool = false;

            if (tmpVal < 100 && tmpVal > 50)
            {

                testBool = true;

            }

            return testBool;
        }

        /// <summary> 

        /// Test for non-alpha values in the text box and 

        /// return the results 

        /// </summary> 

        /// <returns>boolean</returns> 

        private bool txtAlphaNumericStringIsValid(string txtAlphaNumericString)
        {

            // Make sure the string is not empty first 

            if (txtAlphaNumericString == string.Empty)
            {

                return true;

            }

            // check for alphanumeric values 

            char[] testArr = txtAlphaNumericString.ToCharArray();

            bool testBool = false;

            for (int i = 0; i < testArr.Length; i++)
            {

                if (!char.IsLetter(testArr[i]) && !char.IsNumber(testArr[i]))
                {

                    testBool = true;

                }

            }

            return testBool;

        }

        /// <summary> 

        /// Test for special character values in the textbox 

        /// </summary> 

        /// <returns>boolean</returns> 

        private bool txtSpecialCharsIsValid(string txtSpecialChars)
        {

            // Make sure the string is not empty first 

            if (txtSpecialChars == string.Empty)
            {

                return false;

            }

            char[] testArr = txtSpecialChars.ToCharArray();

            bool testBool = false;

            for (int i = 0; i < testArr.Length; i++)
            {

                if (!char.IsSymbol(testArr[i]))
                {

                    testBool = true;

                }

                if (char.IsLetterOrDigit(testArr[i]))
                {

                    testBool = false;

                }

            }

            return testBool;
        }

        private bool txtMinLengthTestIsValid(string txtMinLengthTest)
        {

            char[] testArr = txtMinLengthTest.ToCharArray();

            bool testBool = false;

            if (testArr.Length < 3)
            {

                testBool = true;

            }

            return testBool;
        }

        public static bool txtInputIsNotEmpy(string txt)
        {
            if (txt==string.Empty)
                return true;
            return false;
        }
        public static bool TXTPriceIsValid(string txt)
        {
            // Make sure the string is not empty first 

            if (txt == string.Empty)
            {

                return true;

            }
            if (txtNumericStringIsValid(txt))
                if (txt.Contains(",")) return false;

                else if (txtNumericStringIsValid(txt)) return true;
            return false;

        }
        public static string TimeIsvalis(string TxtTime)
        {
            string[] chunks = TxtTime.Split(':');
            if (chunks[0].Trim() == string.Empty && chunks[1].Trim() == string.Empty)
                TxtTime = "00" + "00";
            else if (chunks[1].Trim() == string.Empty)
                TxtTime= chunks[0] + "00";

            return TxtTime;
        }
        public static bool DueDatetimIsValid(string from,string to)
        {
            if (KM77.BLL.BLLDate.Compare(to, from) <= 0)
                return false;
            return true;
        }



        private static int GetExceptionFromStringToInt(string number)
        {
            int convertedNumber = 0;

            if (!int.TryParse(number, out convertedNumber))
                throw new Exception("Can not convert string to PersianDate");

            return convertedNumber;
        }
        public  static void MyPersianDate(string persianDate)
        {
            string[] chunks = persianDate.Trim().Split('/');

            if (chunks.Count() != 3 && chunks.Count() != 7)
                throw new Exception("Invalid PersianDate Format...");


            int Year = GetExceptionFromStringToInt(chunks[2]);
            int Month = GetExceptionFromStringToInt(chunks[1]);
            int Day = GetExceptionFromStringToInt(chunks[0]);


        }
    }
}
