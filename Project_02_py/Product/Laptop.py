from Product.Device import Device

class Laptop(Device):
    def __init__(self, brand, name, os, size, chip, ram, capacity, color, price, keyboard):
        super().__init__(brand, name, os, size, chip, ram, capacity, color, price)
        self.KeyBoard = keyboard
    
    def Info(sefl):
        super().Info()
        print("Brand: " + sefl.Brand)
        print("Name: " + sefl.Name)
        print("OS: " + sefl.Os)
        print("Size: " + sefl.Size)
        print("Chip: " + sefl.Chip)
        print("Ram: " + str(sefl.Ram))
        print("Capacity: " + str(sefl.Capacity))
        print("Price: " + str(sefl.Price))
        print("Key Board: " + sefl.KeyBoard)
        print("--------------------------------------------")

    def ListedPrice(sefl):
        return sefl.Price + sefl.Price*0.15 + 50000