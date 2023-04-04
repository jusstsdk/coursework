import psutil


def get_cpu_info():
    cpu_info = psutil.cpu_freq()

    print("Процессор:")
    print(f"Максимальная частота: {cpu_info.max:.2f} МГц")
    print(f"Минимальная частота: {cpu_info.min:.2f} МГц")
    print(f"Текущая частота: {cpu_info.current:.2f} МГц")
    print(f"Количество ядер: {psutil.cpu_count()}")


def get_memory_info():
    mem_info = psutil.virtual_memory()

    print("Память:")
    print(f"Всего: {mem_info.total / 1024 / 1024:.2f} МБ")
    print(f"Использовано: {mem_info.used / 1024 / 1024:.2f} МБ")
    print(f"Свободно: {mem_info.available / 1024 / 1024:.2f} МБ")
    print(f"Процент использования: {mem_info.percent}%")


def get_disk_info():
    disk_info = psutil.disk_partitions()

    print("Диски:")
    for partition in disk_info:
        print(f"Метка: {partition.device}")
        print(f"Файловая система: {partition.fstype}")
        print(f"Метка тома: {partition.mountpoint}")
        print(f"Всего: {psutil.disk_usage(partition.mountpoint).total / 1024 / 1024:.2f} МБ")
        print(f"Всего: {format(psutil.disk_usage('/'))}")
        print(f"Использовано: {psutil.disk_usage(partition.mountpoint).used / 1024 / 1024:.2f} МБ")
        print(f"Свободно: {psutil.disk_usage(partition.mountpoint).free / 1024 / 1024:.2f} МБ")
        print(f"Процент использования: {psutil.disk_usage(partition.mountpoint).percent}%")
        print("=" * 30)

