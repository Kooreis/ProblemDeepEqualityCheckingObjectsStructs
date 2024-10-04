Here is a simple console application in JavaScript that performs deep equality checking between two objects:

```javascript
function deepEqual(obj1, obj2) {
    if (obj1 === obj2) {
        return true;
    }

    if (typeof obj1 !== "object" || obj1 === null || typeof obj2 !== "object" || obj2 === null) {
        return false;
    }

    let keys1 = Object.keys(obj1);
    let keys2 = Object.keys(obj2);

    if (keys1.length !== keys2.length) {
        return false;
    }

    for (let key of keys1) {
        if (!keys2.includes(key) || !deepEqual(obj1[key], obj2[key])) {
            return false;
        }
    }

    return true;
}

let obj1 = {a: 1, b: 2, c: {d: 4}};
let obj2 = {a: 1, b: 2, c: {d: 4}};

console.log(deepEqual(obj1, obj2)); // true

let obj3 = {a: 1, b: 2, c: {d: 5}};
let obj4 = {a: 1, b: 2, c: {d: 4}};

console.log(deepEqual(obj3, obj4)); // false
```

This application defines a function `deepEqual` that takes two objects as arguments and returns `true` if they are deep equal and `false` otherwise. It then tests this function with two pairs of objects: `obj1` and `obj2` (which are deep equal) and `obj3` and `obj4` (which are not deep equal). The results of these tests are printed to the console.