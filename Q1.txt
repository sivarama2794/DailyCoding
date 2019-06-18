//Implement function ToLowerCase() that has a string parameter str, and returns the same string in lowercase.

char * toLowerCase(char * str)
{
    
    char *s = str;
    //Parse through the End of the String
    while(*str != '\0')
    {
        //If the Character is in Caps 
        if(*str>='A' && *str <='Z')
        {
            //Add 32 to push the Upper case to Lower Case (eg:A Ascii Value is 65+32 = 97 Ascii Value of a)
            *str = *str + 32;
        }
        ++str;
    }
    return s;

}

