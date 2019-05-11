#include <iostream>
#include <string>
#include <algorithm>

#include "C.h"

void C::solve() {
	std::string s;
	std::cin >> s;

	int count1 = 0;
	int count2 = 0;

	for (int i = 0; i < s.size(); ++i) {
		int num = std::stoi(s.substr(i, 1));
		//check even start
		if (num % 2 == i % 2)
			count1++;
		// check odd start
		if (num % 2 != i % 2)
			count2++;
	}
	std::cout << (count1 < count2 ? count1 : count2) << std::endl;
}