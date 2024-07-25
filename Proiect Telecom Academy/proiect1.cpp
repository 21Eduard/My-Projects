#include<iostream>
using namespace std;
struct biblioteca
{
    int ci, ap; //ci=cod identificare, ap=an publicatie
    string autor, numec, numep; //numec=nume carte, numep=nume persoana ce imprumuta cartea
};
struct persoana
{
    string numep, carte_imprumutata;
};
int w[100];
int main()
{
    int ci, pozitie, ap, i, index=0, nr_p=0; //index este pentru carti, index2 este pentru carti imprumutate
    char op;
    string autor, numec, numep;
    persoana m[100];
    biblioteca v[100]; //vectorul v este pentru carti, vectorul w este pentru carti imprumutate
    do{
        cout<<"Introduceti operatia dorita: ";
        cin>>op;
        switch(op)
        {
        case 'Q': //am folosit Q pentru a iesi din program folosind o operatie
            {
                cout<<"La revedere!"<<endl;
                break;
            }
        case 'A':
            {
                cout<<"Cod identificare carte: "; cin>>ci;
                cout<<"Nume autor: "; cin>>autor;
                cout<<"Nume carte: "; cin>>numec;
                cout<<"An publicatie carte: "; cin>>ap;
                v[index].ci=ci;
                v[index].autor=autor;
                v[index].numec=numec;
                v[index].ap=ap;
                index++;
                break;
            }
        case 'L':
            {
                cout<<"Cartile din biblioteca sunt: "<<endl;
                for(i=0;i<index;i++)
                {
                    cout<<v[i].numec<<endl;
                }
                break;
            }
        case 'E':
            {
                cout<<"Introduceti ID-ul cartii ce urmeaza a fi eliminata: ";
                cin>>ci;
                cout<<endl;
                for(i=0;i<=index;i++)
                {
                    if(v[i].ci==ci)
                    {
                        pozitie=i;
                        break;
                    }
                }
                for(i=pozitie;i<=index;i++)
                {
                    v[i]=v[i+1];
                }
                index--;
                break;
            }
        case 'I':
            {
                cout<<"Introduceti numele persoanei: ";
                cin>>numep;
                m[nr_p].numep=numep;
                cout<<"Introduceti codul cartii imprumutate: ";
                cin>>ci;
                for(i=0;i<index;i++)
                {
                    if(v[i].ci==ci)
                    {
                        w[i]=1;
                        m[nr_p].carte_imprumutata=v[i].numec;
                        break;
                    }
                }
                nr_p++;
                break;
            }
        case 'C':
            {
                cout<<"Introduceti codul cartii pentru detalii: ";
                cin>>ci;
                int j;
                for(i=0;i<index;i++)
                {
                    if(v[i].ci==ci)
                    {

                        j=i;
                    }
                }
                cout<<"Nume carte: "<<v[j].numec<<endl<<"Nume autor: "<<v[j].autor<<endl<<"An publicatie: "<<v[j].ap<<endl<<"Imprumutata: ";
                for(i=0;i<index;i++)
                {
                    if(v[i].ci==ci)
                    {
                        if(w[i]==1)
                            cout<<"Da";
                        else
                        {
                            cout<<"Nu";
                        }
                    }
                }
                cout<<endl;
                break;
            }
        case 'P':
            {
                cout<<"Introduceti numele persoanei: ";
                cin>>numep;
                cout<<"Cartile lui "<<numep<<" sunt: "<<endl;
                for(i=0;i<nr_p;i++)
                {
                    if(m[i].numep==numep)
                    {
                        cout<<m[i].carte_imprumutata<<endl;
                    }
                }
            break;
            }
        default:
            {
                cout<<"Operatie gresita!"<<endl;
                break;
            }
        }
    }while(op!='Q');
    return 0;
}
