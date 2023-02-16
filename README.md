# YandexMarketParser

### Одностраничный веб проект на ASP.NET Core.

#### Алгоритм работы метода контроллера:

1. При открытии страницы должна подгружаться информация из XML файла. Файл доступен по URL: http://partner.market.yandex.ru/pages/help/YML.xml

2. После обработки файла из полученного списка offers найти offer с Id = 12344

3. Сохранить offer в базу данных SQL SERVER через Entity. Если уже есть offer с таким Id, то сохранять не нужно.

4. Отобразить offer на View. Верстка bootstrap.
