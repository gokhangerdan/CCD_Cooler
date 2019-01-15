#include <OneWire.h>
#include <DallasTemperature.h>

#define ONE_WIRE_BUS 2

OneWire oneWire(ONE_WIRE_BUS);

DallasTemperature sensors(&oneWire);

float temperature;

int peltier = 3; //The N-Channel MOSFET is on digital pin 3
int power = 0; //Power level fro 0 to 99%
int peltier_level = map(power, 0, 99, 0, 255); //This is a value from 0 to 255 that actually controls the MOSFET

void setup(){
Serial.begin(9600);
sensors.begin();

//pinMode(peltier, OUTPUT);
}

void loop(){
  
sensors.requestTemperatures();
temperature = sensors.getTempCByIndex(0);

char option;

if(Serial.available() > 0)
{
option = Serial.read();
if(option == 'a') 
power += 10;
else if(option == 'z')
power -= 10;

if(power > 99) power = 99;
if(power < 0) power = 0;

peltier_level = map(power, 0, 99, 0, 255);
}

Serial.println(temperature);
delay(150);
Serial.println(temperature, 0);
delay(150);
Serial.println(power);
delay(150);

analogWrite(peltier, peltier_level); //Write this new value out to the port

}


