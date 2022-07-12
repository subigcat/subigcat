package com.example.myapplication;

public class carsample {
    private String carnumber;
    private String carmodel;
    private String carfixitem;
    private String cartime;
    private String cartext;
    private int km;


    @Override
    public String toString() {
        return "carsample{" + "carnumber='" + carnumber + '\'' + ",carmodel=" + carmodel +'\'' + ",carfixitem=" + carfixitem +'\''  + ",cartime=" + cartime + '\'' + ",cartext=" + cartext + '\'' + ",km=" + km+'}';
    }

    public Integer getKm() {
        return km;
    }

    public void setKm(Integer km) {
        this.km = km;
    }
    public String getCartime() {
        return cartime;
    }

    public void setCartime(String cartime) {
        this.cartime = cartime;
    }

    public String getCartext() {
        return cartext;
    }

    public void setCartext(String cartext) {
        this.cartext = cartext;
    }

    public String getCarfixitem() {
        return carfixitem;
    }

    public void setCarfixitem(String carfixitem) {
        this.carfixitem = carfixitem;
    }


    public String getCarmodel() {
        return carmodel;
    }

    public void setCarmodel(String carmodel) {
        this.carmodel = carmodel;
    }

    public String getCarnumber() {
        return carnumber;
    }

    public void setCarnumber(String carnumber) {
        this.carnumber = carnumber;
    }
}
