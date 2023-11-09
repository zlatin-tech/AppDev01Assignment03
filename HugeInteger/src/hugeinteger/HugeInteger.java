/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 * Click nbfs://nbhost/SystemFileSystem/Templates/Classes/Class.java to edit this template
 */
package hugeinteger;

/**
 *
 * @author zlatintsvetkov
 */
public class HugeInteger {

    private String value;

    public HugeInteger(String value) {
        this.setValue(value);

    }

    public void setValue(String value) {
        if (isValidInteger(value)) {
            value = removeLeadingZeros(value);
            if (value.isBlank() || value.equals("-")) {
                value = "0";
            }
            this.value = value;
        }
    }

    public String getValue() {
        return value;
    }

    private static boolean isValidInteger(String input) {
        //if there are no digits in the input
        int length = input.length();
        if (length == 0 || (length == 1 && input.charAt(0) == '-')) {
            return false;
            //or I could just make input = 0; and return true;
        }

        for (int i = 0; i < input.length(); i++) {
            char c = input.charAt(i);
            if (c < '0' || c > '9') {
                if (i == 0 && c == '-') {
                    continue;
                }
                return false;
            }
        }
        return true;
    }

    private static String removeLeadingZeros(String input) {
        // Check if the input string is empty or consists of just a single '-' character
        if (input.isEmpty() || (input.length() == 1 && input.charAt(0) == '-')) {
            return input;
        }

        // If the first character is '0', remove it and recursively process the rest of the string
        if (input.charAt(0) == '0') {
            return removeLeadingZeros(input.substring(1));
        }

        // If the first character is '-', keep it and recursively process the rest of the string
        if (input.charAt(0) == '-') {
            return "-" + removeLeadingZeros(input.substring(1));
        }

        // If the first character is not '0' or '-', return the remaining string
        return input;

    }

    //------------------ PART I METHODS
    public HugeInteger add(HugeInteger number2){
        String answer = "";
        //convert to string
        String num1 = this.value, num2 = number2.getValue();
        //find how many leading zeros to add to make same length
        int leadingZeros = Math.abs(num1.length() - num2.length());
        
        if ((num1.contains("-")&& !num2.contains("-"))
                ||((!num1.contains("-")&& num2.contains("-")))) {
            leadingZeros += 1;
        }
        //add leading zeros on necessary number
        
        //add extra 0 in case of carry on last (left most) digit
        //loop through strings (now both of same length)
        //parse char(i) to int
        //perform addition
        //ifresult is two digits, 
        return new HugeInteger(answer);
    }
    public String toString() {
        return value;
    }

    public boolean isZero() {
        String n = this.toString();
        if (n.charAt(0) == '0') {
            return true;
        }
        if (n.charAt(0) == '-' && n.charAt(1) == '0') {
            return true;
        }
        return false;
    }

    //-----------------PART II: COMPARING HUGE INTEGERS METHODS
    public boolean isEqualTo(HugeInteger number2) {
        String value = this.value, value2 = number2.getValue();
        if (value.equals(value2)) {
            return true;
        }
        return false;
    }

    public boolean isNotEqualTo(HugeInteger number2) {
        return !this.isEqualTo(number2);
    }

    public boolean isGreaterThan(HugeInteger number2) {
        String value = this.value, value2 = number2.getValue();

        //check if either is less than 0 without the other
        if (!value.contains("-") && value2.contains("-")) {
            return true;
        }
        if (value.contains("-") && !value2.contains("-")) {
            return false;
        }

        //check if they are positive or negative
        boolean arePositive = value.charAt(0) != '-';

        //check which has more digits
        if (arePositive) {
            if (value.length() > value2.length()) {
                return true;
            }
            if (value.length() < value2.length()) {
                return false;
            }
            for (int i = 0; i < value.length(); i++) {
                if (value.charAt(i) > value2.charAt(i)) {
                    return true;
                }
            }
        } else {
            if (value.length() > value2.length()) {
                return false;
            }
            if (value.length() < value2.length()) {
                return true;
            }
            for (int i = 0; i < value.length(); i++) {
                if (value.charAt(i) < value2.charAt(i)) {
                    return true;
                }
            }
        }
        return false;
    }

    public boolean isLessThan(HugeInteger number2) {
        String value = this.value, value2 = number2.getValue();
        if (!value.contains("-") && value2.contains("-")) {
            return false;
        }
        if (value.contains("-") && !value2.contains("-")) {
            return true;
        }

        boolean arePositive = value.charAt(0) != '-';
        if (arePositive) {
            if (value.length() > value2.length()) {
                return false;
            }
            if (value.length() < value2.length()) {
                return true;
            }

            for (int i = 0; i < value.length(); i++) {
                if (value.charAt(i) < value2.charAt(i)) {
                    return true;
                }
            }
        } else {
            if (value.length() > value2.length()) {
                return true;
            }
            if (value.length() < value2.length()) {
                return false;
            }

            for (int i = 0; i < value.length(); i++) {
                if (value.charAt(i) > value2.charAt(i)) {
                    return true;
                }
            }
        }
        return false;
    }

    public boolean isGreaterThanOrEqualTo(HugeInteger number2) {
        return this.isGreaterThan(number2) || this.isEqualTo(number2);
    }

    public boolean isLessThanOrEqualTo(HugeInteger number2) {
        return this.isLessThan(number2) || this.isEqualTo(number2);
    }

}
