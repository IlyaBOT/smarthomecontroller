#include <Servo.h> // Подключаем библиотеку для управления сервоприводами.
#include <GParser.h> // Подключаем библиотеку парсинга данных.
#include <parseUtils.h> // Доп. библиотека для библиотеки GParser.h

#define STATUS_LED 13 // Объявляем 13 пин для светодиода.
#define BUZZER_PIN 11 // Объявляем 11 пин для пищалки.
#define LIGHT_1 10 // Объявляем 10 пин для управления осветительным прибором 1.
#define MOTOR_1 9 // Объявляем 9 пин для управления электромотором 1.
#define RELAY_1 8 // Объявляем 8 пин для электронного выключатея 1 (Обычное реле или твердотельное реле на мосфет-транзисторе).
#define RELAY_2 7 // Объявляем 7 пин для электронного выключатея 2 (Обычное реле или твердотельное реле на мосфет-транзисторе).
#define SERVO_1 6 // Объявляем 6 пин для управления сервоприводом 1.

Servo servo1; // Объявляем сервопривод servo1.

void setup() {
  // Устанавливаем 10 битный 15.6 кГц ШИМ на 10,9 пинах.
  TCCR1A = 0b00000011;  // 10bit
  TCCR1B = 0b00001001;  // x1 fast pwm
  
  Serial.begin(115200); // Устанавливаем соединение по последовательному порту со скоростью 115200 бод.
  Serial.setTimeout(32); // Устанавливаем таймаут передачи в 32 мс.
  
  pinMode(STATUS_LED, OUTPUT); // Устанавливаем пин светодиода как выходной.
  pinMode(BUZZER_PIN, OUTPUT); // Устанавливаем пин пищалки как выходной.
  pinMode(LIGHT_1, OUTPUT); // Устанавливаем пин осветительным прибора 1 над столом как выходной.
  pinMode(MOTOR_1, OUTPUT); // Устанавливаем пин электромотора 1 как выходной.
  pinMode(SERVO_1, OUTPUT); // Устанавливаем пин сервопривода 1 как выходной.
  pinMode(RELAY_1, OUTPUT); // Устанавливаем пин электронного выключатея 1 как выходной.
  pinMode(RELAY_2, OUTPUT); // Устанавливаем пин электронного выключатея 2 как выходной.
//pinMode(A0, INPUT); // [DEBUG ONLY] Устанавливаем пин потенциометра как входной.
//servo1.attach(SERVO_1);  // Подключаем сервопривод.
  
  digitalWrite(STATUS_LED, HIGH); // Включаем светодиод.
  delay(32); // Ожидание 32 мс
  tone(BUZZER_PIN, 2000, 128); // Воспроизводим писк с частотой 2кГц.
                               // длительностью 128 мс как оповещение о готовности.
  digitalWrite(STATUS_LED, LOW); // Выключаем светодиод.
}

// Протокол общения с контроллером по UART:
// 0 - Пусто
// 1 - Динамик (Buzzer) (0...2048,0...4096)
// 2 - Свет над столом (0...1023)
// 3 - Электродвигатель [Вентилятор 2pin] (0...1023)
// 4 - Зарезервированно
// 5 - Электронный выключатель 1
// 6 - Электронный выключатель 2
//
// Реализовать:
// 4 - Окно [Сервопривод] (0...180) (Управление в градусах)
// 

void loop() {
  if(Serial.available()){ // Проверяем готовность последовательного порта.
    char str[30]; // Создаём  массив символов str на 31 элемент.
    
    int amount = Serial.readBytesUntil(';', str, 30); // Чтение данных из последовательного порта.
    str[amount] = NULL; // Обнуляем свободное место в массиве от мусора.

    GParser data(str, ','); // Парсим данные из массива str с разделителем - запятой в data.

    unsigned int ints[2]; // Объявляем массив положитльных чисел на 3 элемента.
    data.parseInts(ints); // Парсим данные из data в массив ints.

    switch(ints[0]){ // Ключ
      case 1: tone(BUZZER_PIN, ints[1], ints[2]); break;  // Когда ключ равен 1, то воспроизводим звук с частотой 2 элемента
                                                          // массива ints, и продолжительностью 3 элемента массива ints.
      case 2: analogWrite(LIGHT_1, (ints[1] == 255 ? 256 : ints[1])); break; // Когда ключ равен 2, то генерируем ШИМ сигнал с заполнением 2 элемента массива ints.
      case 3: analogWrite(MOTOR_1, (ints[1] == 255 ? 256 : ints[1])); break; // Когда ключ равен 3, то генерируем ШИМ сигнал с заполнением 2 элемента массива ints.
//    case 4: servo1.write(ints[1]); break; // Когда ключ равен 4, то задаём угол сервоприводу servo1 равному 2 элементу массива ints.
      case 5: digitalWrite(RELAY_1, ints[1]); break; // Когда ключ равен 5, то задаём состояние электрического выключателя 1 равному 2 элементу массива ints.
      case 6: digitalWrite(RELAY_2, ints[1]); break; // Когда ключ равен 6, то задаём состояние электрического выключателя 2 равному 2 элементу массива ints.
    }
  }
}
