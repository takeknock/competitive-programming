
#include <iostream>
#include <string>


class Solver {
public:
    void solve();
};


void Solver::solve() {
    // ����
    int n;

    std::cin >> n;

    int ans = 1000000;
    for (std::size_t i = 0; i < n; ++i) {
        int count = 0;
        int tmp;
        std::cin >> tmp;
        while (tmp % 2 == 0) {
            tmp /= 2;
            count++;
        }
        ans = ans > count ? count : ans;
    }

    std::cout << ans << std::endl;    
}

int main() {
    Solver solver = Solver();
    solver.solve();
    return 0;
}