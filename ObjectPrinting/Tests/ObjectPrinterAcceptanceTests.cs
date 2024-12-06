﻿using System;
using System.Globalization;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace ObjectPrinting.Tests
{
    [TestFixture]
    public class ObjectPrinterAcceptanceTests
    {
        [Test]
        public void Demo()
        {
            var person = new Person { Name = "Alex", Age = 19 };
            
            var printer = ObjectPrinter.For<Person>();
            printer.Exclude<Guid>().SerializeFor<string>((name, value) => $"{name} have {value}")
                .   UseCulture();
            
            //1. Исключить из сериализации свойства определенного типа
            //2. Указать альтернативный способ сериализации для определенного типа
            //3. Для числовых типов указать культуру
            //4. Настроить сериализацию конкретного свойства
            //5. Настроить обрезание строковых свойств (метод должен быть виден только для строковых свойств)
            //6. Исключить из сериализации конкретного свойства

            var s1 = printer.PrintToString(person);
                
                
                
            Console.WriteLine(s1);
            //7. Синтаксический сахар в виде метода расширения, сериализующего по-умолчанию        
            //8. ...с конфигурированием
        }

       
    }
}