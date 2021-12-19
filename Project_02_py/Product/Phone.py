from Product.Device import Device


class Phone(Device):
    def __init__(self, brand, name, os, size, chip, ram, capacity, color, price,sim):
        super().__init__(brand, name, os, size, chip, ram, capacity, color, price)
        self.Sim = sim
    def Info(sefl):
        super().Info()
        print("Brand: " + sefl.Brand)
        print("Name: " + sefl.Name)
        print("OS: " + sefl.Os)
        print("Size: " + sefl.Size)
        print("Chip: " + sefl.Chip)
        print("Ram: " + str(sefl.Ram))
        print("Capacity: " + str(sefl.Capacity))
        print("Price: " + str(sefl.ListedPrice()))
        print("Sim: " + sefl.Sim)
        print("--------------------------------------------")
        
    def ListedPrice(sefl):
        return sefl.Price + sefl.Price*0.1 + 200000
