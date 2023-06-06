# Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Примеры:

* [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]

* [“1234”, “1567”, “-2”, “computer science”] → [“-2”]

* [“Russia”, “Denmark”, “Kazan”] → []

# Описание решения задачи:

 Первым делом создаем массив **array** типа **string** (я создал из 5-и элементов, можно изменить количество).

 Затем создаем функцию **FillArray** типа **string**, которая принимает в себя текстовый массив. Задача функции **FillArray** реализовать заполнение массива с клавиатуры пользователем (реализовано это через цикл **while**). На выходе получаем заполненый массив. 

 Следуюшим шагом создаем функцию **NewArray** типа **string** , которая принимает в себя текстовый массив.Она будет выполнять две задачи. 
 1. Определение размера нового массива.
 2. Создаем новый массив **newArray** необходимой длины.
 3. Заполнение нового массива элементами начального массива длинной не более 3 символов

 Определение размера нового массива реализовано через цикл **for** и условие **if**, которые перебирают все элементы изначального массива и проверяют их длину, количество подходящих элементов записывается в переменную **count**.

 Заполнение нового массива элементами начального массива длинной не более 3 символов так же реализовано через цикл **for** и условие **if**, которые пеербирают все элементы изначального массива и вставляют подходящими элементами новый массив **newArray**. Для корректной подстановки элементов вводим переменную **j**, которая будет увеличивать индекс элемента мссива **newArray** на 1 с каждой итерацией.

 На выходе функции **newArray** получаем масив длиной равной количеству элементов массива **array**, состоящих из не более чем 3-х символов, и заполненный этими элементами.

