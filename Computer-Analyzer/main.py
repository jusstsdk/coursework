import configuration_analysis as ca
import device_analysis as da

if __name__ == '__main__':
    # Анализ конфигурации компьютера
    ca.get_cpu_info()
    ca.get_memory_info()
    ca.get_disk_info()

    # Анализ подключенных устройств
    da.get_device_info()






