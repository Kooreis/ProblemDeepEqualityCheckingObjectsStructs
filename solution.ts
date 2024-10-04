Here is a TypeScript console application that performs deep equality checking between two objects:

```typescript
function deepEqual(obj1: any, obj2: any) {
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

let obj1 = {a: 1, b: 2, c: {d: 3, e: 4}};
let obj2 = {a: 1, b: 2, c: {d: 3, e: 4}};
let obj3 = {a: 1, b: 2, c: {d: 3, e: 5}};

console.log(deepEqual(obj1, obj2)); // true
console.log(deepEqual(obj1, obj3)); // false
```

This application defines a function `deepEqual` that takes two objects and returns `true` if they are the same down to the level of nested properties, and `false` otherwise. It then tests this function with three objects: `obj1` and `obj2`, which are identical, and `obj3`, which differs from `obj1` in the value of a nested property. The results of these tests are printed to the console.