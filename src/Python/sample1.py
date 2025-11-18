"""
Sample Python file with intentional code quality issues
"""

# Unused import
import sys
import os

# Global variable - bad practice
GLOBAL_VAR = "global"

def function_with_issues(data):
    """Process data with issues."""
    # Unused variable
    unused_variable = "never used"
    
    # Bare except - bad practice
    try:
        result = int(data)
    except:
        pass
    
    # Magic number
    return data * 42

def complex_function(a, b, c, d):
    """Function with high complexity."""
    if a > 0:
        if b > 0:
            if c > 0:
                if d > 0:
                    return a + b + c + d
                else:
                    return a + b + c - d
            else:
                return a + b - c + d
        else:
            return a - b + c + d
    else:
        return -a + b + c + d

# No docstring
def no_documentation():
    print("This function has no documentation")

# Line too long
def function_with_long_line():
    very_long_variable_name = "This is a very long string that exceeds the recommended line length and should be split into multiple lines for better readability"
    return very_long_variable_name

if __name__ == "__main__":
    function_with_issues("test")
