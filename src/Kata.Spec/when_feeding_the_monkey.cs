﻿using System;
using FluentAssertions;
using Machine.Specifications;

namespace Kata.Spec
{
    public class when_feeding_the_monkey
    {
        static Monkey _systemUnderTest;
        
        Establish context = () => 
            _systemUnderTest = new Monkey();

        Because of = () => 
            _systemUnderTest.Eat("banana");

        It should_have_the_food_in_its_belly = () =>
            _systemUnderTest.Belly.Should().Contain("banana");
    }
    //test github repo
    //test local pull
    // Given the user input is empty when calculating the sum then it should return zero.
    public class when_user_input_is_empty
    {
        Establish _context = () => { _systemUnderTest = new Calculator(); };

        Because of = () => { _result = _systemUnderTest.Add(); };

        It should_return_zero = () => { _result.Should().Be(0); };
        static Calculator _systemUnderTest;
        static int _result;
    }

    public class when_user_input_one_number

    {

        Establish _context = () => { _systemUnderTest = new Calculator(); };

        Because of = () => { _result = _systemUnderTest.Add("3"); };

        It should_return_same_number = () => { _result.Should().Be(3); };
        private static Calculator _systemUnderTest;
        private static int _result;
    }

    // Given the user input is one number when calculating the sum then it should return the same number. (example "3" should equal 3)
    // Given the user input is two numbers when calculating the sum then it should return the sum of those numbers. (example "1,2" should equal 3)
    public class when_user_input_is_two_numbers
    {
        Establish _context = () => { _systemUnderTest = new Calculator(); };

        Because of = () => { _result = _systemUnderTest.Add("1,2"); };

        It should_return_the_sum = () => { _result.Should().Be(3); };
        static Calculator _systemUnderTest;
        static int _result;
    }

    public class when_input_unkonw_amount_numbers

    {

        Establish _context = () => { _systemUnderTest = new Calculator(); };

        Because of = () => { _result = _systemUnderTest.Add("1,2,3"); };

        It should_return_sum_all_numbers = () => { _result.Should().Be(6); };
        private static Calculator _systemUnderTest;
        private static int _result;
    }
    
    // Given the user input is an unknown amount of numbers when calculating the sum then it should return the sum of all the numbers. (example "1,2,3" should equal 6)
    // Given the user input is multiple numbers with new line and comma delimiters when calculating the sum then it should return the sum of all the numbers. (example "1\n2,3" should equal 6)
    public class when_input_has_new_line_delimiter
    {
        Establish _context = () => { _systemUnderTest = new Calculator(); };

        Because of = () => { _result = _systemUnderTest.Add("1,2\n3"); };

        It should_return_the_sum = () => { _result.Should().Be(6); };
        static Calculator _systemUnderTest;
        static int _result;
    }

    public class when_input_contains_negatives

    {

        Establish _context = () => { _systemUnderTest = new Calculator(); };

        Because of = () => { _result = Catch.Exception(() => _systemUnderTest.Add("-1,2,3")); };

        It should_return_Exception = () => { _result.Message.Should().Be("negatives not allowed: -1"); };
        private static Calculator _systemUnderTest;
        private static Exception _result;
    }
    // Given the user input contains one negative number when calculating the sum then it should throw an exception "negatives not allowed: x" (where x is the negative number).
    // Given the user input contains multiple negative numbers mixed with positive numbers when calculating the sum then it should throw an exception "negatives not allowed: x, y, z" (where x, y, z are only the negative numbers).
    public class when_input_has_multiple_negatives
    {
        Establish _context = () => { _systemUnderTest = new Calculator(); };

        Because of = () => { _result = Catch.Exception(()=> _systemUnderTest.Add("1,-2,-3,4")); };

        It should_throw_an_exception = () => { _result.Message.Should().Be("negatives not allowed: -2, -3"); };
        static Calculator _systemUnderTest;
        static Exception _result;
    }

    public class when_contains_numbers_larger_than_onethousand

    {

        Establish _context = () => { _systemUnderTest = new Calculator(); };

        Because of = () => { _result = _systemUnderTest.Add("2,1001"); };

        It should_sum_number_less_onethousandone = () => { _result.Should().Be(2); };
        private static Calculator _systemUnderTest;
        private static int _result;
    }
    // Given the user input contains numbers larger than 1000 when calculating the sum it should only sum the numbers less than 1001. (example 2 + 1001 = 2)
    // Given the user input is multiple numbers with a custom multi-character delimiter when calculating the sum then it should return the sum of all the numbers. (example: “//[]\n12***3” should return 6)
    // Given the user input is multiple numbers with multiple custom delimiters when calculating the sum then it should return the sum of all the numbers. (example “//[][%]\n12%3” should return 6)
}
