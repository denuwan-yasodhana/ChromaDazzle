// Use 13 - 2 pins 
/*
  led1  = 13
  led2  = 12
  led3  = 11
  led4  = 10
  led5  = 9
  led6  = 8
  led7  = 7
  led8  = 6
  led9  = 5
  led10 = 4
  led11 = 3
  led12 = 2
*/

char c;
String InputData;


void setup() {
  Serial.begin(9600);

  pinMode(2,OUTPUT);  digitalWrite(2, LOW);
  pinMode(3,OUTPUT);  digitalWrite(3, LOW);
  pinMode(4,OUTPUT);  digitalWrite(4, LOW);
  pinMode(5,OUTPUT);  digitalWrite(5, LOW);
  pinMode(6,OUTPUT);  digitalWrite(6, LOW);
  pinMode(7,OUTPUT);  digitalWrite(7, LOW);
  pinMode(8,OUTPUT);  digitalWrite(8, LOW);
  pinMode(9,OUTPUT);  digitalWrite(9, LOW);
  pinMode(10,OUTPUT); digitalWrite(10, LOW);
  pinMode(11,OUTPUT); digitalWrite(11, LOW);
  pinMode(12,OUTPUT); digitalWrite(12, LOW);
  pinMode(13,OUTPUT); digitalWrite(13, LOW);
  
}

void loop() {

  while(Serial.available()>0)
  {
      c = Serial.read();
      InputData += c;
    }
  
  if(c=='#')
  {
    
      if(InputData=="1ON#"){digitalWrite(13, HIGH);}
      else if(InputData=="1OFF#"){digitalWrite(13, LOW);}
  
      if(InputData == "2ON#"){digitalWrite(12, HIGH);}
      else if(InputData == "2OFF#"){digitalWrite(12, LOW);}

      if(InputData == "3ON#"){digitalWrite(11, HIGH);}
      else if(InputData == "3OFF#"){digitalWrite(11, LOW);}

      if(InputData == "4ON#"){digitalWrite(10, HIGH);}
      else if(InputData == "4OFF#"){digitalWrite(10, LOW);}

      if(InputData == "5ON#"){digitalWrite(9, HIGH);}
      else if(InputData == "5OFF#"){digitalWrite(9, LOW);}

      if(InputData == "6ON#"){digitalWrite(8, HIGH);}
      else if(InputData == "6OFF#"){digitalWrite(8, LOW);}

      if(InputData == "7ON#"){digitalWrite(7, HIGH);}
      else if(InputData == "7OFF#"){digitalWrite(7, LOW);}

      if(InputData == "8ON#"){digitalWrite(6, HIGH);}
      else if(InputData == "8OFF#"){digitalWrite(6, LOW);}

      if(InputData == "9ON#"){digitalWrite(5, HIGH);}
      else if(InputData == "9OFF#"){digitalWrite(5, LOW);}

      if(InputData == "10ON#"){digitalWrite(4, HIGH);}
      else if(InputData == "10OFF#"){digitalWrite(4, LOW);}

      if(InputData == "11ON#"){digitalWrite(3, HIGH);}
      else if(InputData == "11OFF#"){digitalWrite(3, LOW);}

      if(InputData == "12ON#"){digitalWrite(2, HIGH);}
      else if(InputData == "12OFF#"){digitalWrite(2, LOW);}

      if(InputData == "1P#"){pattern01();}
      else if(InputData == "2P#"){pattern02();}
      else if(InputData == "3P#"){pattern03();}
      else if(InputData == "4P#"){pattern04();}
      else if(InputData == "5P#"){pattern05();}
      else if(InputData == "6P#"){pattern06();}
      else if(InputData == "7P#"){pattern07();}
      else if(InputData == "8P#"){pattern08();}
      else if(InputData == "9P#"){pattern09();}

       c = 0;
       InputData = "";
          
    }

}



void pattern01()
{
  
  int t = 100;
  for(int i = 2; i <= 13; i++)
  {
      digitalWrite(i, HIGH);
      delay(t);
    }

    for(int i = 2; i <= 13; i++)
  {
      digitalWrite(i, LOW);
      delay(t);
    }

    for(int i = 13; i > 1; i--)
  {
      digitalWrite(i, HIGH);
      delay(t);
    }

    for(int i = 13; i > 1; i--)
  {
      digitalWrite(i, LOW);
      delay(t);
    }
  }

void pattern02()
{
  int t = 100;
  for(int i = 2; i <= 13; i++)
  {
      digitalWrite(i, HIGH);
      delay(t);
      digitalWrite(i, LOW);
    }

   for(int i = 13; i > 1; i--)
  {
      digitalWrite(i, HIGH);
      delay(t);
      digitalWrite(i, LOW);
    }
    
  }

void pattern03()
{
  int t = 150;
  for(int i = 2; i <= 13; i+=2)
  {
      digitalWrite(i, HIGH);
      delay(t);
    }

  for(int i = 2; i <= 13; i+=2)
  {
      digitalWrite(i, LOW);
      delay(t);
    }


  for(int i = 3; i <= 13; i+=2)
  {
      digitalWrite(i, HIGH);
      delay(t);
    }


  for(int i = 3; i <= 13; i+=2)
  {
      digitalWrite(i, LOW);
      delay(t);
    }
  }

void pattern04()
{
  int t=80;

  digitalWrite(2, HIGH );
  delay(t);
  digitalWrite(3,HIGH);
  delay(t);
  digitalWrite(4,HIGH);
  delay(t);
  
  for(int i = 5; i <= 13; i++)
  {
      digitalWrite(i, HIGH);
      digitalWrite(i-3, LOW);
      delay(t);
    }
  digitalWrite(11,LOW);
  delay(t);
  digitalWrite(12,LOW);
  delay(t);
  digitalWrite(13,LOW);
  delay(t);

  digitalWrite(13, HIGH );
  delay(t);
  digitalWrite(12,HIGH);
  delay(t);
  digitalWrite(11,HIGH);
  delay(t);

  for(int i = 10; i > 1; i--)
  {
      digitalWrite(i, HIGH);
      digitalWrite(i+3, LOW);
      delay(t);
    }
  digitalWrite(4,LOW);
  delay(t);
  digitalWrite(3,LOW);
  delay(t);
  digitalWrite(2,LOW);
  delay(t);
  
  }

void pattern05()
{
  int t = 100;
  digitalWrite(2, HIGH );
  digitalWrite(13, HIGH );
  delay(t);
  digitalWrite(3,HIGH);
  digitalWrite(12, HIGH );
  delay(t);
  digitalWrite(4,HIGH);
  digitalWrite(11, HIGH );
  delay(t);
  digitalWrite(5,HIGH);
  digitalWrite(10,HIGH);
  delay(t);
  digitalWrite(6,HIGH);
  digitalWrite(9,HIGH);
  delay(t);
  digitalWrite(7,HIGH);
  digitalWrite(8,HIGH);
  delay(t);
  digitalWrite(2, LOW );
  digitalWrite(13, LOW );
  delay(t);
  digitalWrite(3,LOW);
  digitalWrite(12, LOW );
  delay(t);
  digitalWrite(4,LOW);
  digitalWrite(11, LOW );
  delay(t);
  digitalWrite(5,LOW);
  digitalWrite(10,LOW);
  delay(t);
  digitalWrite(6,LOW);
  digitalWrite(9,LOW);
  delay(t);
  digitalWrite(7,LOW);
  digitalWrite(8,LOW);
  delay(t);


  digitalWrite(7, HIGH );
  digitalWrite(8, HIGH );
  delay(t);
  digitalWrite(6,HIGH);
  digitalWrite(9, HIGH );
  delay(t);
  digitalWrite(5,HIGH);
  digitalWrite(10, HIGH );
  delay(t);
  digitalWrite(4,HIGH);
  digitalWrite(11,HIGH);
  delay(t);
  digitalWrite(3,HIGH);
  digitalWrite(12,HIGH);
  delay(t);
  digitalWrite(2,HIGH);
  digitalWrite(13,HIGH);
  delay(t);
  digitalWrite(7, LOW );
  digitalWrite(8, LOW );
  delay(t);
  digitalWrite(6,LOW);
  digitalWrite(9, LOW );
  delay(t);
  digitalWrite(5,LOW);
  digitalWrite(10, LOW );
  delay(t);
  digitalWrite(4,LOW);
  digitalWrite(11,LOW);
  delay(t);
  digitalWrite(3,LOW);
  digitalWrite(12,LOW);
  delay(t);
  digitalWrite(2,LOW);
  digitalWrite(13,LOW);
  delay(t);
  
  }

void pattern06()
{
  int t = 100;
  digitalWrite(2, HIGH );
  digitalWrite(13, HIGH );
  delay(t);
  digitalWrite(2, LOW );
  digitalWrite(13, LOW );
  delay(t);
  digitalWrite(3,HIGH);
  digitalWrite(12, HIGH );
  delay(t);
  digitalWrite(3,LOW);
  digitalWrite(12, LOW );
  delay(t);
  digitalWrite(4,HIGH);
  digitalWrite(11, HIGH );
  delay(t);
  digitalWrite(4,LOW);
  digitalWrite(11, LOW );
  delay(t);
  digitalWrite(5,HIGH);
  digitalWrite(10,HIGH);
  delay(t);
  digitalWrite(5,LOW);
  digitalWrite(10, LOW );
  delay(t);
  digitalWrite(6,HIGH);
  digitalWrite(9,HIGH);
  delay(t);
  digitalWrite(6,LOW);
  digitalWrite(9, LOW );
  delay(t);
  digitalWrite(7,HIGH);
  digitalWrite(8,HIGH);
  delay(t);
  digitalWrite(7,LOW);
  digitalWrite(8, LOW );
  delay(t);
  digitalWrite(8,HIGH);
  digitalWrite(7,HIGH);
  delay(t);
  digitalWrite(8,LOW);
  digitalWrite(7, LOW );
  delay(t);
  digitalWrite(9,HIGH);
  digitalWrite(6,HIGH);
  delay(t);
  digitalWrite(9,LOW);
  digitalWrite(6, LOW );
  delay(t);
  digitalWrite(10,HIGH);
  digitalWrite(5,HIGH);
  delay(t);
  digitalWrite(10,LOW);
  digitalWrite(5, LOW );
  delay(t);
  digitalWrite(11,HIGH);
  digitalWrite(4,HIGH);
  delay(t);
  digitalWrite(11,LOW);
  digitalWrite(4, LOW );
  delay(t);
  digitalWrite(12,HIGH);
  digitalWrite(3,HIGH);
  delay(t);
  digitalWrite(12,LOW);
  digitalWrite(3, LOW );
  delay(t);
  digitalWrite(13,HIGH);
  digitalWrite(2,HIGH);
  delay(t);
  digitalWrite(13,LOW);
  digitalWrite(2, LOW );
  delay(t);
  
  }

void pattern07()
{
  for(int i = 0; i < 8; i++)
  {
    int num_of_leds = 12;
    int t = 400;
    int randomnum = random(2, num_of_leds + 1);
    digitalWrite(randomnum, HIGH);
    delay(t);
    digitalWrite(randomnum, LOW);
    delay(t);
    }
  }

void pattern08()
{
  int t = 150;
  for(int i = 2; i <= 13; i++)
  {
      digitalWrite(i, HIGH);
    }
 
 delay (1000);
 
for(int x = 13; x > 1; x--)
{
  for(int i = x; i <= 13; i++)
  {
      digitalWrite(i, LOW);
      digitalWrite(i+1, HIGH);
      delay(t);
    }
  }
 
  }

void pattern09()
{
  int t = 150;
  for(int i = 2; i <= 13; i++)
  {
      digitalWrite(i, LOW);
    }
 
 delay (1000);

  for(int x = 1; x < 13; x++)
{
  for(int i = 1; i <= 13-x ; i++)
  {
      digitalWrite(i, LOW);
      digitalWrite(i+1, HIGH);
      delay(t);
    }
  }
  }  
