
String mySt="";

String mySt1="";


void setup() {
  Serial.begin(9600);
}

void loop() {
  if (Serial.available()) {
    mySt = Serial.readString();
    mySt1 = Serial.readString();

    int sum = mySt.toInt()+mySt1.toInt(); 

    Serial.print(sum);
  }
}