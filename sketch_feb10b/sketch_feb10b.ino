#include <OneWire.h>
#include <DallasTemperature.h>

#define ONE_WIRE_BUS 2

OneWire oneWire(ONE_WIRE_BUS);

DallasTemperature sensors(&oneWire);

float temperature;
int requestedTemperature = 10;

int peltier = 3;
int power = 0;
int peltier_level = map(power, 0, 99, 0, 255);

void setup(){
  Serial.begin(9600);
  sensors.begin();
}

void loop(){
  sensors.requestTemperatures();
  temperature = sensors.getTempCByIndex(0);

  if(temperature > requestedTemperature)
  power += 1;
  else if(temperature < requestedTemperature)
  power -=1;

  delay(2000);

  if(power > 99) power = 99;
  if(power < 0) power = 0;

  peltier_level = map(power, 0, 99, 0, 255);

  Serial.println(temperature);
  delay(150);
  Serial.println(temperature, 0);
  delay(150);
  Serial.println(power);
  delay(150);

  analogWrite(peltier, peltier_level);
}

