int[] array = new int[10]{123, 536, 646, 341, 986, 445, 728, 108, 789, 441};
int count = 0;

for(int i = 0; i < array.Length; i++) {
    if(array[i] % 2 == 0) {
        count += 1;
    }
}

Console.Write($"Количество четных чисел в массиве: {count}");