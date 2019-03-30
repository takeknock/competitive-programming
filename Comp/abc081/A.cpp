#include <iostream>
#include <string>

#include "A.h"


void A::solve() {
    // “ü—Í
    std::string s;
    std::cin >> s;

    int ans = 0;
    for (std::size_t i = 0; i < s.size(); ++i)
    {
        if (s[i] == '1')
            ans++;
    }

    std::cout << ans << std::endl;

}