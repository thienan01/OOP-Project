
class PhoneStore:
    storeName =  "AT Phone"
    def viewDeviceList(deviceList):
        for phone in deviceList:
            phone.Info()

    def findDeviceByName(deviceList,searchSting):
        for phone in deviceList:
            if  (phone.Name.find(searchSting) != -1):
                phone.Info()

    def sortByPrice(deviceList):
        sorted(deviceList, key= lambda device: device.Price)
        for phone in deviceList:
            phone.Info()

    def viewStaffList(staffList):
        for staff in staffList:
            staff.Info()
    def findSalesmanHighestSalary(staffList):
        for staff in staffList:
            for staff2 in staffList:
                if staff.Salary() < staff2.Salary():
                    a = staff2
        print("***** The salesman has highest salary *****")
        a.Info()
    def findStaffByPosAndName(staffList, pos, name):
        for staff in staffList:
            if staff.Position == pos:
                if staff.Name == name:
                    staff.Info()