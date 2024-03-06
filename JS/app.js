// Problem 1:
let salaries = {
    John: 100,
    Ann: 160,
    Pete: 130
}

const sumValues = salaries => Object.values(salaries).reduce((a, b) => a + b);
let sum = sumValues(salaries);
console.log(sum);
// or
console.log(Object.values(salaries).reduce((a, b) => a + b));

// Problem 2:
let menu = {
    width: 200,
    height: 300,
    title: "My menu"
};

// function multiplyNumeric(obj) {
//     for (let property in obj) {
//         if (typeof obj[property] == "number") {
//             obj[property] *= 2;
//         }
//     }
// }

function multiplyNumeric(obj) {
    for (let property in obj) {
        if (typeof obj[property] == "number") {
            obj[property] *= 2;
        }
    }
}

multiplyNumeric(menu);

console.log(menu);

// Problem 3:
function checkEmailId(str) {
    var atIndex = str.indexOf('@');
    var dotIndex = str.indexOf('.');
    if (atIndex < 0 || dotIndex < 0) {
        return false;
    }
    if (atIndex > dotIndex || atIndex + 1 === dotIndex) {
        return false;
    }
    return true;
}

console.log(checkEmailId("@12."));
console.log(checkEmailId("as@.as"));
console.log(checkEmailId(".ads@"));
console.log(checkEmailId("adsdas@asdsa"));
console.log(checkEmailId("asdasd"));
console.log(checkEmailId("."));

// Problem 4:
function truncate(str, maxlength) {
    if (str.length <= maxlength) {
        return str;
    }
    return str.substring(0, maxlength - 1) + "...";
}

console.log(truncate("What I'd like to tell on this topic is:", 20));
console.log(truncate("Hi everyone!", 20));

// Problem 5:
let arr = ["James", "Brennie"];
console.log(arr);

arr.push("Robert");
console.log(arr);

arr[Math.floor(arr.length / 2)] = "Calvin";
console.log(arr);

arr.shift();
console.log(arr);

arr.unshift("Regal");
arr.unshift("Rose");
console.log(arr);