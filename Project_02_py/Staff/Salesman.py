
from Staff.Person import Person


class Salesman(Person): 
    def __init__(self, name, cmnd, yOfBirth, baseSalary,position, numOfDeviceSold, numOfDayOff):
        super().__init__(name, cmnd, yOfBirth, baseSalary,position)
        self.NumOfDeviceSold = numOfDeviceSold
        self.NumOfDayOff = numOfDayOff
    def Salary(self):
        return self.BaseSalary + self.NumOfDeviceSold*100000 - self.NumOfDayOff*(self.BaseSalary/30)
    def Info(self):
        super().Info()
        print("Name: " + self.Name)
        print("CMND: " + self.CMND)
        print("Year of birth: " + self.YearOfBirth)
        print("Position : " + self.Position)
        print("Number of devices sold: " + str(self.NumOfDeviceSold))
        print("Number of days off: " + str(self.NumOfDayOff))
        print("Salary: " + str(self.Salary()))
        print("--------------------------------------------")

