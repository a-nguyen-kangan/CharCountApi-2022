var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

// A route to /matchCharacter 

app.MapGet("/matchCharacter/{character}/{word}", (string character, string word) => MatchCharacters(character, word));

app.Run();


// Create an function declaration/signature
// return type int
// name MatchCharacters
// parameters/inputs:  character, word


int MatchCharacters(string character, string word) {
    int charCount = 0;

    // for loop has three parts/statements - 1. starting point 2. end point/definition 3. What happens to the counter every iteration
    for (int i = 0; i < word.Length; i++) {
        // using the square brackets allows us to access each character in a string
        if(character == word[i].ToString()) {
            charCount++;
        }
    }

    return charCount;
}

int AddTwoNumbers(int num1, int num2) {
    return num1 + num2;
}