int[] array = new int[10]{123, 536, 646, 341, 986, 445, 728, 108, 789, 441};
int temp;
for(int i = 0; i < array.Length / 2; i++) {
    temp = array[i];
    array[i] = array[array.Length - (1 + i)];
    array[array.Length - (1 + i)] = temp;
}

foreach(int item in array) {
    Console.Write($"{item} ");
}


