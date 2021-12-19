
import os
from Product.Phone import Phone
from Product.Laptop import Laptop
from Staff.CEO import CEO
from Staff.Manager import Manager
from Staff.Salesman import Salesman
from Store.PhoneStore import PhoneStore
def deviceManagement(deviceList, phoneList, laptopList):
        os.system('cls' if os.name == 'nt' else 'clear')
        while True:
                print("1. View phone list\n"+
                "2. View laptop list\n"+
                "3. Search by name\n"+
                "4. Sort device by price\n"+
                "0. Back to home")
                choice = input()
                if choice =="1":
                        PhoneStore.viewDeviceList(phoneList)
                if choice == "2":
                        PhoneStore.viewDeviceList(laptopList)
                if choice == "3":
                        print("Enter device: ",end="")
                        searchString = input()
                        PhoneStore.findDeviceByName(deviceList,searchString)
                if choice == "4":
                        PhoneStore.sortByPrice(deviceList)
                if choice == "0":
                        main()
def staffManagement(staffList,saleManList,managerList,ceoList):
        os.system('cls' if os.name == 'nt' else 'clear')
        while True:
                print("1. View salesman list\n" +
                "2. View manager list\n" +
                "3. View CEO list\n" +
                "4. Find the salesman has highest salary\n" +
                "5. Find staff by position and name\n" +
                "0. Go to home")
                choice = input()
                if choice =="1":
                        PhoneStore.viewStaffList(saleManList)
                if choice == "2":
                        PhoneStore.viewStaffList(managerList)
                if choice == "3":
                        PhoneStore.viewStaffList(ceoList)
                if choice == "4":
                        PhoneStore.findSalesmanHighestSalary(staffList)
                if choice == "5":
                        print("Enter the position: ", end="")
                        pos = input()
                        print("Enter the name: ", end="")
                        name = input()
                        PhoneStore.findStaffByPosAndName(staffList,pos,name)
                if choice == "0":
                        main()
def main():
        phone1 = Phone("Apple","Iphone 13","IOS", "6.5", "A15", 6, 512,"Black",25990000,"Doul sim")
        phone2 = Phone("Samsung","Samsung S21","Android", "6.3", "SnapDragon 990", 6, 512,"Black",22990000,"Doul sim")
        phoneList = [phone1,phone2]

        laptop1 = Laptop("Asus", "Zenbook 14","Window 10", "14", "Intel i7", 8, 512, "Blue", 22990000, "Led")
        laptop2 = Laptop("Apple", "MacBook Pro M1 2020","IOS", "13.3", "Apple M11", 16, 512, "Grey", 42990000, "Led")
        laptopList = [laptop1,laptop2]
        deviceList = [phone1,phone2,laptop1,laptop2]
        salesman1 = Salesman("Le Van A", "123345234","1990",8000000, "Sale", 10, 1)
        salesman2 = Salesman("Le Van B", "456135753","1992",8000000, "Sale", 20, 3)
        salesmanList = [salesman1, salesman2]

        manager1 = Manager("Nguyen Thi E", "234567426", 1990, 12000000,"Manager", 24)
        manager2 = Manager("Nguyen Thi F", "274468142", 1989, 12000000,"Manager", 12)
        managerList = [manager1,manager2]

        ceo1 = CEO("Tran Van Q", "153475253", 1970, 40000000, "CEO", "Marketing", 2)
        ceo2 = CEO("Tran Van k", "236532723", 1971, 40000000, "CEO", "Sale", 4)
        ceoList = [ ceo1, ceo2 ]
        staffList = [salesman1, salesman2,manager1,manager2,ceo1,ceo2]
        while True:
                os.system('cls' if os.name == 'nt' else 'clear')
                print("Welcome to "+ PhoneStore.storeName)
                print("1.Device management\n"+
                "2.Staff management")
                choice = input()
                print(choice)
                if choice == "1":
                        deviceManagement(deviceList,phoneList,laptopList)
                if choice == "2":
                        staffManagement(staffList, salesmanList, managerList,ceoList)

if __name__ == "__main__":
        main()