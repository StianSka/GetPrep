interface ButtonProps {
  btntype?: "primary" | "dark" | "secondary";
  children: string;
  onClick: () => void;
}

const Button = ({ btntype = "dark", children, onClick }: ButtonProps) => {
  return (
    <button type="button" className={"btn btn-" + btntype} onClick={onClick}>
      {children}
    </button>
  );
};

export default Button;
