```cpp
#include <iostream>

struct MyStruct {
    int a;
    float b;
    char c;
};

bool isEqual(const MyStruct& obj1, const MyStruct& obj2) {
    if (obj1.a == obj2.a && obj1.b == obj2.b && obj1.c == obj2.c) {
        return true;
    }
    return false;
}

int main() {
    MyStruct obj1 = {1, 2.0f, 'a'};
    MyStruct obj2 = {1, 2.0f, 'a'};
    MyStruct obj3 = {2, 3.0f, 'b'};

    if (isEqual(obj1, obj2)) {
        std::cout << "obj1 and obj2 are equal" << std::endl;
    } else {
        std::cout << "obj1 and obj2 are not equal" << std::endl;
    }

    if (isEqual(obj1, obj3)) {
        std::cout << "obj1 and obj3 are equal" << std::endl;
    } else {
        std::cout << "obj1 and obj3 are not equal" << std::endl;
    }

    return 0;
}
```