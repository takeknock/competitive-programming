#include "SubString.h"

// from https://qiita.com/drken/items/a207e5ae3ea2cf17f4bd
void Solver::solve() {
    using namespace std;
    // ����
    int n;
    string S;
    cin >> n >> S;

    // �O�����z��
    vector<vector<int> > next = calcNext(S);

    // DP
    vector<long long> dp(n + 1, 0);
    dp[0] = 1; // �������A�󕶎��� "" �ɑΉ�
    for (int i = 0; i < n; ++i) {
        for (int j = 0; j < 26; ++j) {
            if (next[i][j] >= n) continue; // ���̕��� j �������Ȃ��ꍇ�̓X���[
            add(dp[next[i][j] + 1], dp[i]);
        }
    }

    // �W�v
    long long res = 0;
    for (int i = 0; i <= n; ++i) add(res, dp[i]);

    cout << res - 1 << endl;
}

const int MOD = 1000000007;

// res[i][c] := i �����ڈȍ~�ōŏ��ɕ��� c ���o�ꂷ�� index (���݂��Ȃ��Ƃ��� n)
std::vector<std::vector<int> > Solver::calcNext(const std::string &S) {
    using namespace std;    
    int n = (int)S.size();
    vector<vector<int> > res(n + 1, vector<int>(26, n));
    for (int i = n - 1; i >= 0; --i) {
        for (int j = 0; j < 26; ++j) res[i][j] = res[i + 1][j];
        res[i][S[i] - 'a'] = i;
    }
    return res;
}

// mod 1000000007 �̐��E�� a += b ����֐�
void Solver::add(long long &a, long long b) {
    a += b;
    if (a >= MOD) a -= MOD;
}