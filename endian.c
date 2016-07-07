#include <stdint.h>
#include <stdio.h>

int main()
{
  uint8_t t = 1;
  if ((t & 0x01) != 1)
    printf("BigEndian\n");
  else
    printf("LittleEndian\n");
  return 0;
}
