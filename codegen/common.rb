require_relative 'parser'

class IndentedOutput
  def initialize(io, level=0, with="    ")
    @io = io
    @level = level
    @with = with
  end
  def push
    @level+=1
  end
  def pop
    @level-=1 if @level > 0
    @level
  end
  def puts(s)
    @io.puts((@with*@level + s).rstrip)
  end

  def block
    push
    yield
    pop
  end
end

CSHARP_KEYWORDS = %w(abstract as base break byte case catch checked
  class const continue default delegate do else enum event
    explicit extern false finally fixed for foreach goto if implicit
    in interface internal is lock namespace new null object operator
    out override params private protected public readonly ref return 
    sealed sizeof stackalloc static struct switch this throw true
    try typeof  unchecked unsafe using  virtual
    volatile while)

def check_csharp_keyword(w)
  return "@#{w}" if CSHARP_KEYWORDS.include?(w.to_s)
  return w
end
