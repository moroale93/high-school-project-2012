//MOTORE X
int motorXpin1=2;
int motorXpin2=3;
int motorXpin3=4;
int motorXpin4=5;
//MOTORE Y
int motorYpin1=8;
int motorYpin2=9;
int motorYpin3=10;
int motorYpin4=11;

int incomingByte=0;
int delaytime=10;

void setup()
{
  Serial.begin(9600);
  //MOTORE X
  pinMode(motorXpin1, OUTPUT);
  pinMode(motorXpin2, OUTPUT);
  pinMode(motorXpin3, OUTPUT);
  pinMode(motorXpin4, OUTPUT);
  //MOTORE Y
  pinMode(motorYpin1, OUTPUT);
  pinMode(motorYpin2, OUTPUT);
  pinMode(motorYpin3, OUTPUT);
  pinMode(motorYpin4, OUTPUT);
}

int posX=0;
void AVANTIX()
{
  posX = (posX%4)+1;
  switch(posX)
  {
    case 1:
      digitalWrite(motorXpin1,HIGH);
      digitalWrite(motorXpin2,LOW);
      digitalWrite(motorXpin3,LOW);
      digitalWrite(motorXpin4,LOW);
      delay(delaytime);
      break;
    case 2:
      digitalWrite(motorXpin1,LOW);
      digitalWrite(motorXpin2,HIGH);
      digitalWrite(motorXpin3,LOW);
      digitalWrite(motorXpin4,LOW);
      delay(delaytime);
      break;
    case 3:
      digitalWrite(motorXpin1,LOW);
      digitalWrite(motorXpin2,LOW);
      digitalWrite(motorXpin3,HIGH);
      digitalWrite(motorXpin4,LOW);
      delay(delaytime);
      break;
    case 4:
      digitalWrite(motorXpin1,LOW);
      digitalWrite(motorXpin2,LOW);
      digitalWrite(motorXpin3,LOW);
      digitalWrite(motorXpin4,HIGH);
      delay(delaytime);
    }
}


void INDIETROX()
{
  posX = ((posX+3)%4);
  switch(posX)
  {
    case 1:
      digitalWrite(motorXpin1,HIGH);
      digitalWrite(motorXpin2,LOW);
      digitalWrite(motorXpin3,LOW);
      digitalWrite(motorXpin4,LOW);
      delay(delaytime);
      break;
    case 2:
      digitalWrite(motorXpin1,LOW);
      digitalWrite(motorXpin2,HIGH);
      digitalWrite(motorXpin3,LOW);
      digitalWrite(motorXpin4,LOW);
      delay(delaytime);
      break;
    case 3:
      digitalWrite(motorXpin1,LOW);
      digitalWrite(motorXpin2,LOW);
      digitalWrite(motorXpin3,HIGH);
      digitalWrite(motorXpin4,LOW);
      delay(delaytime);
      break;
    case 0:
      digitalWrite(motorXpin1,LOW);
      digitalWrite(motorXpin2,LOW);
      digitalWrite(motorXpin3,LOW);
      digitalWrite(motorXpin4,HIGH);
      delay(delaytime);
      break;
  }
}


int posY=0;
void AVANTIY()
{
  posY = (posY%4)+1;
  switch(posY)
  {
    case 1:
      digitalWrite(motorYpin1,HIGH);
      digitalWrite(motorYpin2,LOW);
      digitalWrite(motorYpin3,LOW);
      digitalWrite(motorYpin4,LOW);
      delay(delaytime);
      break;
    case 2:
      digitalWrite(motorYpin1,LOW);
      digitalWrite(motorYpin2,HIGH);
      digitalWrite(motorYpin3,LOW);
      digitalWrite(motorYpin4,LOW);
      delay(delaytime);
      break;
    case 3:
      digitalWrite(motorYpin1,LOW);
      digitalWrite(motorYpin2,LOW);
      digitalWrite(motorYpin3,HIGH);
      digitalWrite(motorYpin4,LOW);
      delay(delaytime);
      break;
    case 4:
      digitalWrite(motorYpin1,LOW);
      digitalWrite(motorYpin2,LOW);
      digitalWrite(motorYpin3,LOW);
      digitalWrite(motorYpin4,HIGH);
      delay(delaytime);
      break;
  }
}


void INDIETROY()
{
  posY = ((posY+3)%4);
  switch(posY)
  {
    case 1:
      digitalWrite(motorYpin1,HIGH);
      digitalWrite(motorYpin2,LOW);
      digitalWrite(motorYpin3,LOW);
      digitalWrite(motorYpin4,LOW);
      delay(delaytime);
      break;
    case 2:
      digitalWrite(motorYpin1,LOW);
      digitalWrite(motorYpin2,HIGH);
      digitalWrite(motorYpin3,LOW);
      digitalWrite(motorYpin4,LOW);
      delay(delaytime);
      break;
    case 3:
      digitalWrite(motorYpin1,LOW);
      digitalWrite(motorYpin2,LOW);
      digitalWrite(motorYpin3,HIGH);
      digitalWrite(motorYpin4,LOW);
      delay(delaytime);
      break;
    case 0:
      digitalWrite(motorYpin1,LOW);
      digitalWrite(motorYpin2,LOW);
      digitalWrite(motorYpin3,LOW);
      digitalWrite(motorYpin4,HIGH);
      delay(delaytime);
      break;
  }
}

void loop()
{
  if (Serial.available() > 0) 
  {
    incomingByte = Serial.read();
    
    switch(incomingByte)
    {
      case 50:
        AVANTIX();
        break;
      case 49:
        INDIETROX();
        break;
      case 51:
        AVANTIY();
        break;
      case 52:
        INDIETROY();
        break;
      default:
        break;
    }
  }
}


