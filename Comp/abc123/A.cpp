#include <iostream>
#include <string>

#include "A.h"

void A::solve() {
    // ����
    int a, b, c, d, e, k;

    std::cin >> a >> b >> c >> d >> e >> k;

    std::string ans = (e - a > k) ? ":(" : "Yay!";


    std::cout << ans << std::endl;
}