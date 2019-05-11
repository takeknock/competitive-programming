#include <iostream>
#include <algorithm>

#include "A.h"

void A::solve() {
	// “ü—Í
	int a, b;
	std::cin >> a >> b;
	int res[4];
	res[0] = a;
	res[1] = a - 1;
	res[2] = b;
	res[3] = b - 1;
	std::sort(res, res + 4, std::greater<int>());

	int ans = res[0] + res[1];
	std::cout << ans << std::endl;
}