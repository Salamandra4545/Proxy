# Паттерн Заместитель (Proxy)

## Описание
Данный проект демонстрирует реализацию паттерна проектирования "Заместитель" на языке C#. В этом примере банковский чек выступает в качестве заместителя для наличных средств на счете. Чек может быть использован вместо наличных денег для совершения покупок и, в конечном счете, контролирует доступ к наличным деньгам на счете чекодателя.

## Структура проекта
- **IBankAccount**: Интерфейс, определяющий методы для работы с банковским счетом (внесение депозита, снятие средств, получение баланса).
- **RealBankAccount**: Класс, представляющий реальный банковский счет, который управляет балансом и выполняет операции.
- **BankAccountProxy**: Класс заместителя, который контролирует доступ к реальному банковскому счету и может включать дополнительные проверки или ведение журнала.
- **Program**: Клиентский код, демонстрирующий использование паттерна заместителя.

## Использование
1. Создайте экземпляр `RealBankAccount`.
2. Создайте экземпляр `BankAccountProxy`, передав в него экземпляр `RealBankAccount`.
3. Используйте методы `Deposit`, `Withdraw` и `GetBalance` через экземпляр `BankAccountProxy` для управления средствами на счете.

## Зависимости
- .NET Core SDK

## Запуск
Для запуска проекта выполните команду:
```
dotnet run
```

## Лицензия
Проект распространяется под лицензией MIT.