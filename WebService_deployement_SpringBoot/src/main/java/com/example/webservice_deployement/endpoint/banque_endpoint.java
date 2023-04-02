package com.example.webservice_deployement.endpoint;


import org.springframework.ws.server.endpoint.annotation.Endpoint;
import com.example.webservice_deployement.service.banqueWS;
import ws.Compte;
import ws.ConvertResponse;
import java.util.List;

@Endpoint
public class banque_endpoint {
    private static final String NAMESPACE_URI = "http://ws/";
    private  banqueWS banqueService;
    private ConvertResponse ConvertResponse;
    public double conversion(double mt){
        return banqueService.conversion(mt);
    }

    public Compte getCompte(int code){
        return banqueService.getCompte(code);
    }

    public List<Compte> listComptes(){
        return banqueService.listComptes();
    }

}

