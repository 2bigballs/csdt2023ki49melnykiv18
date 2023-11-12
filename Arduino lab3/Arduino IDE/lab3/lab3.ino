
#define LEDSTRIPE_ON 150
#define LEDSTRIPE_OFF 0


int num=0;
int customDelay=0;

int ledStripe = A0; 
String receivedLine = "";

void parseLine(String line) {
    int equalPos = line.indexOf('=');
    if (equalPos >= 0) {
        String key = line.substring(0, equalPos);
        String value = line.substring(equalPos + 1);
        if(key == "mode")
        {
          num = value.toInt();
        } 
        if(key == "delay")
        {
          customDelay = value.toInt();
        }
     }
}

void setup() {
  Serial.begin(9600);
  pinMode(ledStripe, OUTPUT);
}

void loop() {

  if (Serial.available() > 0) {
        char receivedChar = Serial.read();

        if (receivedChar == '\n') {
            parseLine(receivedLine);
            receivedLine = "";  
        } 

        else {
            receivedLine += receivedChar;
        }
    }


  if(num == 0)
  {
    analogWrite(ledStripe,LEDSTRIPE_OFF);
  }
  if(num == 1)
  {
    analogWrite(ledStripe,LEDSTRIPE_ON);
  }
  if(num == 2)
  {
    analogWrite(ledStripe,LEDSTRIPE_ON);
    delay(1000);
    analogWrite(ledStripe,LEDSTRIPE_OFF);
    delay(1000);
  }
  if (num == 3)
  {
    analogWrite(ledStripe,LEDSTRIPE_ON);
    delay(750);
    analogWrite(ledStripe,LEDSTRIPE_OFF);
    delay(750);
  }
  if (num == 4)
  {
    analogWrite(ledStripe,LEDSTRIPE_ON);
    delay(500);
    analogWrite(ledStripe,LEDSTRIPE_OFF);
    delay(500);
  }
  if(num == 5)
  {
    analogWrite(ledStripe,LEDSTRIPE_ON);
    delay(250);
    analogWrite(ledStripe,LEDSTRIPE_OFF);
    delay(250);
  }
  if (num == 6)
  {
    analogWrite(ledStripe,LEDSTRIPE_ON);
    delay(customDelay);
    Serial.println(customDelay);
    analogWrite(ledStripe,LEDSTRIPE_OFF);
    delay(customDelay);
  }
}