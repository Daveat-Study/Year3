class Customer{
	
	private String name;
	private boolean member;
	private String memberType;
	
	Customer(String n){
		name = n;
	}
	
	// Getter
	String getName() {
		return name;
	}
	
	boolean isMember() {
		return member;
	}
	
	String getMemberType() {
		return memberType;
	}
	
	// Setter
	void setMember(boolean mb) {
		member = mb;
	}
	
	void setMemberType(String mbType) {
		memberType = mbType;
	}
	
	@Override
	public String toString() {
		return "Customer's name is "+name+" and Membership is "+memberType;
	}
}

class DiscountRate {
	private double serviceDiscountPremium = 0.2;
	private double serviceDiscountGold = 0.2;
	private double serviceDiscountSilver = 0.1;

	private double productDiscountPremium = 0.1;
	private double productDiscountGold = 0.1;
	private double productDiscountSilver = 0.1;
	
	double getServiceDiscountRate(String type) {
		double result = 0.0;
		if (type == "premium") {
			result = serviceDiscountPremium;
		} else if (type == "gold") {
			result = serviceDiscountGold;
		} else if (type == "silver") {
			result = serviceDiscountSilver;
		}
		return result; 
	}
	
	double getProductDiscountRate(String type) {
		double result = 0.0;
		if (type == "premium") {
			result = productDiscountPremium;
		} else if (type == "gold") {
			result = productDiscountGold;
		} else if (type == "silver") {
			result = productDiscountSilver;
		}
		return result; 
	}
}

class Visit extends Customer {
	
	private String date;
	private double serviceExpense;
	private double productExpense;
	DiscountRate discount = new DiscountRate();
	
	Visit(String n, String d){
		super(n);
		date = d;
		this.serviceExpense = 0;
		this.productExpense = 0;
	}
	
	String getName() {
		return super.getName();
	}
	
	// Getter
	double getServiceExpense() {
		return serviceExpense;
	}
	
	double getProductExpense() {
		return productExpense;
	}
	
	// Setter
	void setServiceExpense(double service) {
		serviceExpense = service;
	}
	
	void setProductExpense(double product) {
		productExpense = product;
	}
	
	// Member function
	
	double getTotalExpense() {
		double disService = serviceExpense + (discount.getServiceDiscountRate(super.getMemberType()) /100);
		double disProduct = productExpense + (discount.getProductDiscountRate(super.getMemberType()) /100);
		return disService + disProduct;
	}
	
	public String toString() {
		return super.toString() + " visit on "+ date +" and total spend is " + getTotalExpense();
	}
}

public class III {

	public static void main(String[] args) {
		Visit visit = new Visit("Daveat", "19/Dec/21");
		visit.setMemberType("premium");
		visit.setMember(true);
		visit.setServiceExpense(100);
		visit.setProductExpense(100);
		System.out.println(visit.toString());
	}

}
