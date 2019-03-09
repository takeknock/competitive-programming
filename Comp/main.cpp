
#include <iostream>
#include <vector>
#include <string>
#include <algorithm>


class Solver {
public:
    void solve();
    long long sumXORTo(long long x);
    bool isOdd(long long x);
};

bool Solver::isOdd(long long x) {
    return x % 2 != 0;
}

long long Solver::sumXORTo(long long x) {
    if (x % 2 != 0) {
        long long half = (x + 1) / 2;
        int ret = isOdd(half);
        return ret;
    }
    else {
        long long half = (x + 1) / 2;
        int ret = isOdd(half);
        return ret ^ x;
    }
}


void Solver::solve() {
    using namespace std;
    long long a, b;
    cin >> a >> b;

    long long a1 = sumXORTo(a - 1);
    long long b1 = sumXORTo(b);
    long long result = a1 ^ b1;
    cout << result << endl;
}



int main() {
    Solver solver = Solver();
    solver.solve();
    return 0;
}