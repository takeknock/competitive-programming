#include <iostream>
#include <string>
#include <algorithm>
#include <vector>

class Solver {
public:
    void solve();
};


void Solver::solve() {
	std::string s;
	int n, k;
	std::cin >> n >> k >> s;
	int dp[10009];
	std::fill(dp, dp + 10009, -1);
	int count = 0;
	for (int i = 0; i < n; ++i) {
		int num = std::stoi(s.substr(i, 1));
		if (num == 0) {
			dp[i] = count;
			count++;
		}
		else {
			count = 0;
		}
	}

	for (int i = 0; i < n; ++i) {
		
	}

	std::cout << dp[1000] << std::endl;
}

int main() {
    Solver solver = Solver();
    solver.solve();
    return 0;
}