# import usb.core
# import usb.util
import usb
from usb.backend import libusb1


def get_device_info():
    back = libusb1.get_backend()
    devices = usb.core.find(backend=back, find_all=True)

    for device in devices:

        device_id = device.idVendor, device.idProduct
        manufacturer = usb.util.get_string(device, device.iManufacturer)
        product = usb.util.get_string(device, device.iProduct)

        print(f"Device ID: {device_id}, Manufacturer: {manufacturer}, Product: {product}")
