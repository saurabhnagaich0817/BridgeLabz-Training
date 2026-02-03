public bool IsValid(string s) {
    Stack<char> st=new();
    foreach(char c in s){
        if(c=='('||c=='{'||c=='[') st.Push(c);
        else{
            if(st.Count==0) return false;
            char o=st.Pop();
            if(o=='('&&c!=')'||o=='{'&&c!='}'||o=='['&&c!=']')
                return false;
        }
    }
    return st.Count==0;
}
