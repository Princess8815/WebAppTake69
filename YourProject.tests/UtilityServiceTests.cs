using NUnit.Framework;
using WebApplication1.services;

namespace YourProject.tests
{
    [TestFixture]
    public class UtilityServicesTests
    {
        // -------------------------------
        // 1. CountVowels Tests (8 total)
        // -------------------------------

        // Empty string → no vowels → expect 0
        [Test]
        public void CountVowels_EmptyString_ReturnsZero()
        {
            Assert.AreEqual(0, UtilityServices.CountVowels(""));
        }

        // Word with no vowel characters → expect 0
        [Test]
        public void CountVowels_NoVowels_ReturnsZero()
        {
            Assert.AreEqual(0, UtilityServices.CountVowels("rhythm"));
        }

        // String of lowercase vowels → count is 5
        [Test]
        public void CountVowels_AllVowelsLowercase_ReturnsFive()
        {
            Assert.AreEqual(5, UtilityServices.CountVowels("aeiou"));
        }

        // String of uppercase vowels → still count is 5
        [Test]
        public void CountVowels_AllVowelsUppercase_ReturnsFive()
        {
            Assert.AreEqual(5, UtilityServices.CountVowels("AEIOU"));
        }

        // Mixed case word with 2 vowels → expect 2
        [Test]
        public void CountVowels_MixedCaseWord_ReturnsCorrectCount()
        {
            Assert.AreEqual(2, UtilityServices.CountVowels("ApplE"));
        }

        // Mixed characters + spaces → "Hello World" has 3 vowels
        [Test]
        public void CountVowels_MixedCharacters_ReturnsCorrectCount()
        {
            Assert.AreEqual(3, UtilityServices.CountVowels("Hello World"));
        }

        // Whole sentence test → expect accurate count of 8
        [Test]
        public void CountVowels_SentenceWithSpaces_ReturnsCorrectCount()
        {
            Assert.AreEqual(8, UtilityServices.CountVowels("This is a simple test case"));
        }

        // Null input should return 0 safely
        [Test]
        public void CountVowels_NullInput_ReturnsZero()
        {
            Assert.AreEqual(0, UtilityServices.CountVowels(null));
        }

        // -------------------------------
        // 2. IsLeapYear Tests (10 total)
        // -------------------------------

        // Year divisible by 400 → true
        [Test]
        public void IsLeapYear_Year2000_ReturnsTrue()
        {
            Assert.IsTrue(UtilityServices.IsLeapYear(2000));
        }

        // Divisible by 100 but not 400 → false
        [Test]
        public void IsLeapYear_Year1900_ReturnsFalse()
        {
            Assert.IsFalse(UtilityServices.IsLeapYear(1900));
        }

        // Normal leap year (divisible by 4 but not 100)
        [Test]
        public void IsLeapYear_Year2020_ReturnsTrue()
        {
            Assert.IsTrue(UtilityServices.IsLeapYear(2020));
        }

        // Not divisible by 4 → false
        [Test]
        public void IsLeapYear_Year2021_ReturnsFalse()
        {
            Assert.IsFalse(UtilityServices.IsLeapYear(2021));
        }

        // Divisible by 400 → true
        [Test]
        public void IsLeapYear_Year1600_ReturnsTrue()
        {
            Assert.IsTrue(UtilityServices.IsLeapYear(1600));
        }

        // Century year not divisible by 400 → false
        [Test]
        public void IsLeapYear_Year1700_ReturnsFalse()
        {
            Assert.IsFalse(UtilityServices.IsLeapYear(1700));
        }

        // Modern leap year → true
        [Test]
        public void IsLeapYear_Year2024_ReturnsTrue()
        {
            Assert.IsTrue(UtilityServices.IsLeapYear(2024));
        }

        // Not divisible by 4 → false
        [Test]
        public void IsLeapYear_Year2025_ReturnsFalse()
        {
            Assert.IsFalse(UtilityServices.IsLeapYear(2025));
        }

        // Negative years → invalid → false
        [Test]
        public void IsLeapYear_YearNegative_ReturnsFalse()
        {
            Assert.IsFalse(UtilityServices.IsLeapYear(-2137));
        }

        // Year 0 is divisible by 400 → treated as leap
        [Test]
        public void IsLeapYear_YearZero_ReturnsTrue()
        {
            Assert.IsTrue(UtilityServices.IsLeapYear(0));
        }

        // --------------------------------
        // 3. IsPalindrome Tests (15 total)
        // --------------------------------

        // Single digit number is always a palindrome
        [Test]
        public void IsPalindrome_SingleDigit_ReturnsTrue()
        {
            Assert.IsTrue(UtilityServices.IsPalindrome(7));
        }

        // Two identical digits → palindrome
        [Test]
        public void IsPalindrome_TwoDigitPalindrome_ReturnsTrue()
        {
            Assert.IsTrue(UtilityServices.IsPalindrome(22));
        }

        // Two different digits → not a palindrome
        [Test]
        public void IsPalindrome_TwoDigitNonPalindrome_ReturnsFalse()
        {
            Assert.IsFalse(UtilityServices.IsPalindrome(23));
        }

        // 121 reads the same forwards/backwards
        [Test]
        public void IsPalindrome_ThreeDigitPalindrome_ReturnsTrue()
        {
            Assert.IsTrue(UtilityServices.IsPalindrome(121));
        }

        // 123 does not match backwards
        [Test]
        public void IsPalindrome_ThreeDigitNonPalindrome_ReturnsFalse()
        {
            Assert.IsFalse(UtilityServices.IsPalindrome(123));
        }

        // 12321 is symmetric → true
        [Test]
        public void IsPalindrome_FiveDigitPalindrome_ReturnsTrue()
        {
            Assert.IsTrue(UtilityServices.IsPalindrome(12321));
        }

        // 12345 is not symmetric → false
        [Test]
        public void IsPalindrome_FiveDigitNonPalindrome_ReturnsFalse()
        {
            Assert.IsFalse(UtilityServices.IsPalindrome(12345));
        }

        // Zeros inside do not break palindrome structure
        [Test]
        public void IsPalindrome_NumberWithZerosInside_ReturnsTrue()
        {
            Assert.IsTrue(UtilityServices.IsPalindrome(10501));
        }

        // Ends differ → false
        [Test]
        public void IsPalindrome_NumberWithZerosEnd_ReturnsFalse()
        {
            Assert.IsFalse(UtilityServices.IsPalindrome(10010));
        }

        // Large balanced palindrome number
        [Test]
        public void IsPalindrome_LongPalindrome_ReturnsTrue()
        {
            Assert.IsTrue(UtilityServices.IsPalindrome(123454321));
        }

        // Large non-palindrome number → false
        [Test]
        public void IsPalindrome_LargeNonPalindrome_ReturnsFalse()
        {
            Assert.IsFalse(UtilityServices.IsPalindrome(123456789));
        }

        // String version: radar → true
        [Test]
        public void IsPalindrome_String_ReturnsTrue()
        {
            Assert.IsTrue(UtilityServices.IsPalindrome("radar"));
        }

        // Even-length number that doesn’t match backwards → false
        [Test]
        public void IsPalindrome_NumberWithEvenLengthNonPalindrome_ReturnsFalse()
        {
            Assert.IsFalse(UtilityServices.IsPalindrome(1234));
        }

        // Zero is symmetric → true
        [Test]
        public void IsPalindrome_Zero_ReturnsTrue()
        {
            Assert.IsTrue(UtilityServices.IsPalindrome(0));
        }

        // Negative numbers → not palindromes by definition
        [Test]
        public void IsPalindrome_NegativeNumber_ReturnsFalse()
        {
            Assert.IsFalse(UtilityServices.IsPalindrome(-121));
        }

        // -------------------------------
        // 3b. IsPalindrome Edge Cases
        // -------------------------------

        // Null string input → false
        [Test]
        public void IsPalindrome_NullString_ReturnsFalse()
        {
            Assert.IsFalse(UtilityServices.IsPalindrome((string)null));
        }

        // Empty string → treat as non-palindrome in this implementation
        [Test]
        public void IsPalindrome_EmptyString_ReturnsFalse()
        {
            Assert.IsFalse(UtilityServices.IsPalindrome(""));
        }

        // Whitespace-only string → reads the same backwards → true
        [Test]
        public void IsPalindrome_WhitespaceOnly_ReturnsTrue()
        {
            Assert.IsTrue(UtilityServices.IsPalindrome("   "));
        }

        // Single character → always a palindrome
        [Test]
        public void IsPalindrome_SingleCharacter_ReturnsTrue()
        {
            Assert.IsTrue(UtilityServices.IsPalindrome("a"));
        }

        // Mixed case version of palindrome word → should still match
        [Test]
        public void IsPalindrome_MixedCasePalindrome_ReturnsTrue()
        {
            Assert.IsTrue(UtilityServices.IsPalindrome("RaceCar"));
        }

        // Phrase with punctuation → expected false
        [Test]
        public void IsPalindrome_PunctuationPalindrome_IgnoresCase_ReturnsFalse()
        {
            // This expects false because my method does not removes punctuation.
            Assert.IsFalse(UtilityServices.IsPalindrome("A man, a plan, a canal, Panama"));
        }

        // Numeric string palindrome → true
        [Test]
        public void IsPalindrome_NumericStringPalindrome_ReturnsTrue()
        {
            Assert.IsTrue(UtilityServices.IsPalindrome("12321"));
        }

        // Numeric string non-palindrome → false
        [Test]
        public void IsPalindrome_NumericStringNonPalindrome_ReturnsFalse()
        {
            Assert.IsFalse(UtilityServices.IsPalindrome("12345"));
        }

        // Negative number input rechecked → false
        [Test]
        public void IsPalindrome_NullIntEquivalent_ReturnsFalse()
        {
            Assert.IsFalse(UtilityServices.IsPalindrome(-1));
        }

        // Large palindrome number → true
        [Test]
        public void IsPalindrome_LargeNumberPalindrome_ReturnsTrue()
        {
            Assert.IsTrue(UtilityServices.IsPalindrome(1223221));
        }

        // Large number but not symmetric → false
        [Test]
        public void IsPalindrome_LargeNumberNonPalindrome_ReturnsFalse()
        {
            Assert.IsFalse(UtilityServices.IsPalindrome(1223321));
        }
    }
}



