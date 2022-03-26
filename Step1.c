#include <stdio.h>
#include <stdlib.h>


void fizz_or_buzz(int i) {
	while (i != 0) {
		if (i % 5 == 0 && i % 3 == 0) {
			printf("FizzBuzz\n");
			return;
		}
		if (i % 3 == 0) {
			printf("Fizz\n");
			return;
		}
		if (i % 5 == 0) {
			printf("Buzz\n");
			return;
		}
		return;
	}
	return;
}
int main(int argc, const char* argv[]) {

	int arr[101];

	for (int i = 0; i <= 100;i++) {
		arr[i] = i;
		if (i % 5 == 0 || i % 3 == 0) {
			fizz_or_buzz(i);
			continue;
		}
		printf("%d\n", arr[i]);
	}

	return 0;
}
