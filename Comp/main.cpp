
#include <iostream>
#include <string>


class Solver {
public:
    void solve();
};


void Solver::solve() {
    // ����
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

int main() {
    Solver solver = Solver();
    solver.solve();
    return 0;
}