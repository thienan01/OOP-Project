

from Product.Phone import Phone
from Product.Laptop import Laptop


phone1 = Phone("Apple","Iphone 13","IOS", "6.5", "A15", 6, 512,"Black",25990000,"Doul sim")
phone2 = Phone("Samsung","Samsung S21","Android", "6.3", "SnapDragon 990", 6, 512,"Black",22990000,"Doul sim")
phoneList = [phone1,phone2]

laptop1 = Laptop("Asus", "Zenbook 14","Window 10", "14", "Intel i7", 8, 512, "Blue", 22990000, "Led")
laptop2 = Laptop("Apple", "MacBook Pro M1 2020","IOS", "13.3", "Apple M11", 16, 512, "Grey", 42990000, "Led")
laptopList = [laptop1,laptop2]

for phone in phoneList:
    phone.Info()
for laptop in laptopList:
    laptop.Info()