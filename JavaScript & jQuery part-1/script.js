// Task 1: Clock
function updateTime() {
    var currentDate = new Date();
    var hours = currentDate.getHours();
    var minutes = currentDate.getMinutes();
    var seconds = currentDate.getSeconds();
    var formattedTime = hours + ":" + minutes + ":" + seconds;
    console.log("Clock: " + formattedTime);
  }
  // updateTime(); // current time
//   setInterval(updateTime, 1000); // Update every second
  
  // Task 2: Detect and display years when January 1 falls on a Sunday
  function findYears() {
    console.log("Years when January 1 falls on a Sunday:");
    for (var year = 2014; year <= 2050; year++) {
      var date = new Date(year, 0, 1); // January is represented by index 0
      if (date.getDay() === 0) { // Sunday is represented by index 0
        console.log(year);
      }
    }
  }
  
  findYears();
  
  // Task 3: Guess the number game
  function guessNumber() {
    var randomNumber = Math.floor(Math.random() * 20) + 1;
    var guessedNumber;
    
    while (true) {
      guessedNumber = prompt("Guess a number between 1 and 20:");
      if (guessedNumber === null) {
        console.log("Game ended.");
        break;
      }
      
      guessedNumber = parseInt(guessedNumber);
      
      if (isNaN(guessedNumber) || guessedNumber < 1 || guessedNumber > 20) {
        console.log("Invalid number. Please enter a valid number between 1 and 20.");
      } else if (guessedNumber === randomNumber) {
        console.log("Congratulations! You guessed the correct number.");
        break;
      } else if (guessedNumber < randomNumber) {
        console.log("The guessed number is smaller. Try again.");
      } else {
        console.log("The guessed number is larger. Try again.");
      }
    }
  }
  
  guessNumber();
  
  // Task 4: Display the URL of the web page in the console
  console.log("Current URL: " + window.location.href);
  
  // Task 5: Add "Ru" to the beginning of the string if it's empty or doesn't start with "Ru"
  function addRuPrefix(str) {
    if (str === "" || !str.startsWith("Ru")) {
      str = "Ru" + str;
    }
    return str;
  }
  
  console.log("addRuPrefix('Hello'): " + addRuPrefix("Hello"));
  console.log("addRuPrefix('RuWorld'): " + addRuPrefix("RuWorld"));
  
  // Task 6: Count the number of vowels in a string
  function countVowels(str) {
    var vowels = ["a", "e", "i", "o", "u"];
    var count = 0;
    
    for (var i = 0; i < str.length; i++) {
      if (vowels.includes(str[i].toLowerCase())) {
        count++;
      }
    }
    
    return count;
  }
  
  console.log("countVowels('Hello World'): " + countVowels("Hello World"));
  
  // Task 7: Check if "1" is the first or last element of an array
  function checkFirstOrLast(arr) {
    return arr[0] === 1 || arr[arr.length - 1] === 1;
  }
  
  console.log("checkFirstOrLast([1, 2, 3]): " + checkFirstOrLast([1, 2, 3]));
  console.log("checkFirstOrLast([2, 1]): " + checkFirstOrLast([2, 1]));
  console.log("checkFirstOrLast([2, 4]): " + checkFirstOrLast([2, 4]));
  
  // Task 8: Get the n last elements of an array
// Task 8: Get the n last elements of an array
function getLastElements(arr, n) {
    if (n == undefined) {
      return arr[arr.length - 1];
    } else if(n >= arr.length){
            return arr;
    } else {
      return arr.slice(arr.length - n);
    }
  }
  

  
  console.log("getLastElements([7, 9, 0, -2]): " + getLastElements([7, 9, 0, -2]));
  console.log("getLastElements([7, 9, 0, -2], 3): " + getLastElements([7, 9, 0, -2], 3));
  console.log("getLastElements([7, 9, 0, -2], 6): " + getLastElements([7, 9, 0, -2], 6));
  
  // Task 9: Combine array elements into a string with a separator
  function combineElements(arr, separator) {
    return arr.join(separator);
  }
  
  console.log("combineElements(['Ivanov', 'Ivan', 'Ivanovich'], '***'): " + combineElements(["Ivanov", "Ivan", "Ivanovich"], "***"));
  
  // Task 10: Find the maximum product of two adjacent elements in an array
  function findMaxProduct(arr) {
    var maxProduct = arr[0] * arr[1];
    
    for (var i = 1; i < arr.length - 1; i++) {
      var product = arr[i] * arr[i + 1];
      if (product > maxProduct) {
        maxProduct = product;
      }
    }
    
    return maxProduct;
  }
  
  console.log("findMaxProduct([3, 6, -2, -5, 7, 3]): " + findMaxProduct([3, 6, -2, -5, 7, 3]));
  
 // Task 11: Remove duplicates from an array
function removeDuplicates(arr) {
    const result = [];
    for (const element of arr) {
      if (!result.includes(element)) {
        result.push(element);
      }
    }
    return result;
  }
  
  console.log("removeDuplicates([1, 1, 2, 3, 4, 3, 2]): " + removeDuplicates([1, 1, 2, 3, 4, 3, 2]));
  
  
  // Task 12: Find the area of a polygon consisting of 1x1 squares
  function findArea(n) {
    return Math.pow(n, 2) + Math.pow(n - 1, 2);
  }
  
  console.log("findArea(2): " + findArea(2));
  console.log("findArea(3): " + findArea(3));
  console.log("findArea(4): " + findArea(4));
  