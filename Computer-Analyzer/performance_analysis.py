import psutil

# Получение информации о процессоре
cpu_percent = psutil.cpu_percent()
cpu_freq = psutil.cpu_freq()

print("CPU:")
print(f"    Загрузка: {cpu_percent}%")
print(f"    Частота: {cpu_freq.current} МГц")

# Получение информации о памяти
memory = psutil.virtual_memory()

print("\nПамять:")
print(f"    Всего: {memory.total // (1024 ** 2)} Мб")
print(f"    Используется: {memory.used // (1024 ** 2)} Мб ({memory.percent}%)")

# Получение информации о дисках
disks = psutil.disk_partitions()

print("\nДиски:")
for disk in disks:
    disk_usage = psutil.disk_usage(disk.mountpoint)
    print(f"    {disk.device} ({disk.mountpoint}):")
    print(f"        Всего: {disk_usage.total // (1024 ** 3)} Гб")
    print(f"        Используется: {disk_usage.used // (1024 ** 3)} Гб ({disk_usage.percent}%)")

# Получение информации о сетевых интерфейсах
net_io_counters = psutil.net_io_counters()

print("\nСеть:")
print(f"    Отправлено: {net_io_counters.bytes_sent // (1024 ** 2)} Мб")
print(f"    Получено: {net_io_counters.bytes_recv // (1024 ** 2)} Мб")
