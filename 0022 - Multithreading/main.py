import _thread
import time

def thread_task(nameThread, delay):
  for count in range(1, 6):
    time.sleep(delay)
    print('Thread de nome: {} e número: {}'.format(nameThread, count))

try:
  _thread.start_new_thread(thread_task, ('Thread 1', 2))
  _thread.start_new_thread(thread_task, ('Thread 2', 3))
except Exception as error:
  print('Error: {}'.format(error))

while True:
  pass
