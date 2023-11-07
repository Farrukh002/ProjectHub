// For simplicity I've just used one js file

// 1.Shape class and its inheritors
class Shape {
    GetArea() {
      // This method will be overridden by the inheritors
    }
  }
  
  class Square extends Shape {
    constructor(sideLength) {
      super();
      this.sideLength = sideLength;
    }
  
    GetArea() {
      return this.sideLength ** 2;
    }
  }
  
  class Circle extends Shape {
    constructor(radius) {
      super();
      this.radius = radius;
    }
  
    GetArea() {
      return Math.PI * this.radius ** 2;
    }
  }

  // Example usage
  const square = new Square(5);
  console.log('Square area:', square.GetArea());
  
  const circle = new Circle(3);
  console.log('Circle area:', circle.GetArea());
  

  // 2.Method which displays all fields and methods of any objects
  function displayObject(obj) {
    for (let key in obj) {
      if (typeof obj[key] === 'function') {
        console.log(key + '()');
      } else {
        console.log(key + ': ' + obj[key]);
      }
    }
  }

  // Example usage
  const obj = {
    name: 'John Doe',
    age: 25,
    greet() {
      console.log('Hello!');
    },
  };
  
  const obj2 = {
    fruit: 'Apple',
    color: 'Red',
  };

  console.log('Objects:');
  displayObject(obj);
  displayObject(obj2);


  // 3.Function that retrieves an array [[key, value], ...] instead of an object
  function convertObjectToArray(obj) {
    return Object.entries(obj);
  }

  // Example usage
  const convertedArray = convertObjectToArray(obj);
  console.log('Converted array:');
  console.log(convertedArray);


  // 4.Validator classes
class Validator {
    isValid() {
      throw new Error('isValid method must be implemented');
    }
  }
  
  class EmailValidator extends Validator {
    isValid(email) {
      const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
      return emailRegex.test(email);
    }
  }
  
  class PhoneValidator extends Validator {
    isValid(phoneNumber) {
      const phoneRegex = /^\d{10}$/;
      return phoneRegex.test(phoneNumber);
    }
  }
  
  // Example usage
  const emailValidator = new EmailValidator();
  console.log('Email validation:', emailValidator.isValid('test@example.com'));
  
  const phoneValidator = new PhoneValidator();
  console.log('Phone number validation:', phoneValidator.isValid('1234567890'));
  