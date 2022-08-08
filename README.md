**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 

Для выполнения это задачи:
* нарисуем блок-схему.
* Нам необходимо проверить все элементы массива на количество символов, те что равны трем или длиннее выводим, если меньше трех символов пропускаем.
* Блок-схема выглядит так:
 ![Diag](BlockDiagram.PNG)

* Далее создадим изначальный строчный массив состоящий из семи элементов:
string [] words = {"Do", "No", "Make", "your", "job", "well", "!!!"};
* Далее проверяем элементы на соответствие условию задачи и выводим их, если таковые имеются. В случае если элементы, удовлетворяющие условию, отсутствуют - выводится пустая строка.

Вывод программы:

![Code](Code.PNG)

