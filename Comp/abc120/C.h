#pragma once

#include <iostream>
#include <string>
#include <algorithm>

namespace correct {
    class Solver {
    public:
        void solve();
        int countOf(std::string& s, char target);
    };

    void Solver::solve() {
        std::string s;
        std::cin >> s;
        int count_0 = countOf(s, '0');
        int count_1 = countOf(s, '1');
        int ans = std::min(count_0, count_1) * 2;
        std::cout << ans << std::endl;
    }

    int Solver::countOf(std::string& s, char target) {
        return std::count(s.begin(), s.end(), target);
    }
}


namespace error {
    class Solver {
    public:
        void solve();
        int countAndErase(std::string& s);
    };

    void Solver::solve() {
        std::string s;
        std::cin >> s;
        std::size_t n = s.length();

        int count = 0;

        bool flag = true;
        while (flag) {
            int thisCount = countAndErase(s);
            count += thisCount;
            if (thisCount == 0) {
                flag = false;
            }
        }
        int ans = count;
        std::cout << ans << std::endl;
    }

    int Solver::countAndErase(std::string& s) {
        int lastIndex = s.size() - 1;
        int count = 0;
        for (std::size_t i = 0; i < lastIndex; ++i) {
            if (s[i] != s[i + 1]) {
                count += 2;
                s.erase(s.begin() + i, s.begin() + i + 1);
                i++;
            }
        }
        return count;
    }
} // error
