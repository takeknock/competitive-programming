#include <iostream>
#include <string>

#include "B.h"

void B::solve() {
    // “ü—Í
    int a, b, c, d, e;

    std::cin >> a >> b >> c >> d >> e;

    int min = 10;
    min = a % 10 <= min && a % 10 != 0 ? a % 10 : min;
    min = b % 10 <= min && b % 10 != 0 ? b % 10 : min;
    min = c % 10 <= min && c % 10 != 0 ? c % 10 : min;
    min = d % 10 <= min && d % 10 != 0 ? d % 10 : min;
    min = e % 10 <= min && e % 10 != 0 ? e % 10 : min;


    a = a % 10 == 0 ? a / 10 * 10 : (a / 10 + 1) * 10;
    b = b % 10 == 0 ? b / 10 * 10 : (b / 10 + 1) * 10;
    c = c % 10 == 0 ? c / 10 * 10 : (c / 10 + 1) * 10;
    d = d % 10 == 0 ? d / 10 * 10 : (d / 10 + 1) * 10;
    e = e % 10 == 0 ? e / 10 * 10 : (e / 10 + 1) * 10;
    int ans = a + b + c + d + e - 10 + min;
    std::cout << ans << std::endl;
}