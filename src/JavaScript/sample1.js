// Sample JavaScript file with intentional code quality issues

function processData(data) {
    // Unused variable
    var unusedVar = "This is never used";
    
    // Using var instead of const/let
    var result = data + " processed";
    
    // Missing semicolons
    console.log(result)
    
    return result
}

// Function complexity issue
function complexFunction(a, b, c, d) {
    if (a > 0) {
        if (b > 0) {
            if (c > 0) {
                if (d > 0) {
                    return a + b + c + d;
                } else {
                    return a + b + c - d;
                }
            }
        }
    }
    return 0;
}

// Magic numbers
function calculate() {
    var result = 42 * 100 + 3.14159;
    return result;
}

// No error handling
function riskyOperation() {
    var data = JSON.parse("invalid json");
    return data;
}

module.exports = {
    processData,
    complexFunction,
    calculate
};
